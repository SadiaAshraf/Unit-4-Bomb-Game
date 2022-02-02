using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBomb : MonoBehaviour
{
    public GameObject player;
    public GameObject bombPrefabs;
    public GameObject spawnBombs;

    public bool CollideToPwrBox;
    public bool test = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThrowThreeBalls();
    }

    public void OnCollisionEnter(Collision collPlayer)
    {
        if(collPlayer.gameObject.CompareTag("Player") || collPlayer.gameObject.CompareTag("enemy"))
        {

            CollideToPwrBox = true;
            test = true;
           ThrowThreeBalls();
           // Destroy(gameObject);
            Debug.Log("collider is wokring");

            Debug.Log(" collider box value = " + CollideToPwrBox);
            Debug.Log(" collider test value = " + test);
        }
    }
    public void ThrowThreeBalls()
    {
        if (Input.GetKeyDown(KeyCode.Space) && test == true)
        {
            for (int count = 0; count <= 3; count++)
            {
                spawnBombs = Instantiate(bombPrefabs, transform.position, bombPrefabs.transform.rotation);
                Debug.Log("3 at a time");
                test = false;
            }

        }
        
    }



}
