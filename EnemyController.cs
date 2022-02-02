using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody EnemyRb;
    public GameObject Player;
    public float moveY = -5;
    public float moveZ = 20;
    public float speed = 7f;
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 Follow = (Player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(Follow * speed);

        //if (transform.position.y < moveY )
        //{
        //    Destroy(gameObject);
        //}
       


    }


}
