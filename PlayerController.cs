using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public float Speed;
    private GameObject focalpoint;
    //public float moveX = 25;
    //public float moveZ = 20;

    public int Health =103;
    private int count = 0;
    public GameObject bombPrefabs;
    public GameObject spawnBombs;
    //public GameObject enemybr;
    public float moveY = -5;
    private MultiBomb MultiBombVar;
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        focalpoint = GameObject.Find("focalpoint");
        // enemybr = GameObject.Find("Enemy");
        MultiBombVar = GameObject.Find("Multibombpwr").GetComponent<MultiBomb>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float leftInput = Input.GetAxis("Horizontal");

        PlayerRb.AddForce( Vector3.forward * forwardInput * Speed * Time.deltaTime, ForceMode.Impulse );
        PlayerRb.AddForce( Vector3.right * leftInput * Speed * Time.deltaTime , ForceMode.Impulse);
        SpawningBombs();


        //if (transform.position.y < moveY)
        //{
        //    Destroy(gameObject);
        //}



    }


    public void OnCollisionEnter(Collision collision)
    {
       //if (collision.gameObject.CompareTag("enemy"))
       // {
       //     Health = Health - 1;
       //     if (Health == 0)
       //     {
       //         Destroy(gameObject);
       //         Debug.Log("player destroyed");
       //     }
       // }

    }
    void SpawningBombs()
    {
       
            
             if (MultiBombVar.test != false)
        {
            Debug.Log("player- multi bomb is working");
            MultiBombVar.ThrowThreeBalls();

        }
             else if (Input.GetKeyDown(KeyCode.Space))
        {
                     for (count = 0; count < 1; count++)
                        {
                            spawnBombs = Instantiate(bombPrefabs, transform.position, bombPrefabs.transform.rotation);
                              Debug.Log("this is working");
                        }
            //spawnBombs = Instantiate(bombPrefabs);
            // Vector3 Follow = (enemybr.transform.position - transform.position);

            // spawnBombs.GetComponent<Rigidbody>().AddForce(Follow.normalized * 10, ForceMode.Impulse);
        }







    }


}






















//if (Input.GetKey(KeyCode.LeftArrow))
//{
//    transform.Translate(Vector3.left * Speed * Time.deltaTime);
//}
//else if (Input.GetKey(KeyCode.RightArrow))
//{
//    transform.Translate(Vector3.right * Speed * Time.deltaTime);

//}
//else if (Input.GetKey(KeyCode.UpArrow))
//{
//    transform.Translate(Vector3.forward * Speed * Time.deltaTime);
//}
//else if (Input.GetKey(KeyCode.DownArrow))
//{
//    transform.Translate(Vector3.back * Time.deltaTime * Speed);

//}

//if (transform.position.x > moveX || transform.position.x < -moveX)
//{
//    Destroy(gameObject);
//}
//else if (transform.position.z > moveZ || transform.position.z < -moveZ)
//{
//    Destroy(gameObject);
//}