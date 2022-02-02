using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //public GameObject enemybr;
    //public GameObject bombPrefabs;
    //public GameObject spawnBombs;    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //SpawningBombs();
        transform.Translate(Vector3.forward);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
