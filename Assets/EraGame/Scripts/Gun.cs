using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int maxBullets;
    public float timer;
    public int Bullets;
    public float laserDamage = 10;
    public float plasmaDamage = 30;
    public float energyCostLaser = 30;
    public float energyCostPlasma = 90;
    public float energyRemains;


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
        energyRemains = GetComponent<PlayerController>().energyVault;

        if (energyRemains > 100)
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (Bullets > 0 && Time.time - timer >= 0.2)
                {
                    timer = Time.time;
                    Bullets -= 1;

                    GameObject newBullet = Instantiate(BulletPrefab, Spawn.transform.position, Spawn.transform.rotation);
                    newBullet.GetComponent<Rigidbody>().velocity = Spawn.transform.forward * 300;
                    SoundManager.sm.shootRight();
                   
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
                    SoundManager.sm.shootLeft();
                }
            }
        }
            
    }
}



                
            
    



