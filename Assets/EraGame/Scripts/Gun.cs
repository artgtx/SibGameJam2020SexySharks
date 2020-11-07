using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int maxBullets;
    public float timer;
    public int Bullets;
    public GameObject Spawn;
    public GameObject Spawns;
    public GameObject BulletPrefab;
    void Start()
    {
        Debug.Log(maxBullets);
        Bullets = maxBullets;


    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (Bullets > 0 && Time.time - timer >= 0.2)
            {
                timer = Time.time;
                Bullets -= 1;

                GameObject newBullet = Instantiate(BulletPrefab, Spawn.transform.position, Spawn.transform.rotation);
                newBullet.GetComponent<Rigidbody>().velocity = Spawn.transform.forward * 300;
            }
        }

            if (Input.GetMouseButtonDown(0))
            {
                if (Bullets > 0 && Time.time - timer >= 0.2)
                {
                    timer = Time.time;
                    Bullets -= 1;

                    GameObject newBullets = Instantiate(BulletPrefab, Spawns.transform.position, Spawns.transform.rotation);
                    newBullets.GetComponent<Rigidbody>().velocity = Spawns.transform.forward * 300;
                }
            }
        }
    }



                
            
    



