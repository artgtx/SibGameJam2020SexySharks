﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public Enemy Enemy;

    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            Enemy.TakeDamage();
        }
        Enemy.TakeDamage();
    }


}
