using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject BangEffect;
    public float Health;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
           
           
                Collider[] allcolliders = Physics.OverlapSphere(transform.position, 5f);
                foreach (var item in allcolliders)
                {
                    if (item.attachedRigidbody)
                    {
                        if (item.GetComponent<BodyPart>())
                        {
                            item.GetComponent<BodyPart>().Enemy.TakeDamage();
                        }

                        if (item.attachedRigidbody.GetComponent<PlayerHealth>())
                        {
                            item.attachedRigidbody.GetComponent<PlayerHealth>().TakeDamage();
                        }
                        Vector3 direction = (item.transform.position - transform.position).normalized;
                        item.attachedRigidbody.AddForce(direction * 2000f);

                    }
                }
            

            Instantiate(BangEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}


