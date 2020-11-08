using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarrierController : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject fallenEnemy;

    public float health = 5;
    public float speed = 7;
    public float energyTaken;
    private int enemiesTaken = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fallenEnemy = GameObject.FindGameObjectWithTag("Fallen Enemy");
        GetEnemy();
    }

    void GetEnemy()
    {
        if (fallenEnemy != null)
        {
            Vector3 fallenEnemyPos = fallenEnemy.transform.position;

        if (fallenEnemy)
        {
            agent.SetDestination(fallenEnemyPos);

        }
    }
}

    private void OnTriggerEnter(Collider other)
    {
        if(energyTaken > 0)
        {
            energyTaken = 0;
        }
        energyTaken = 110 * enemiesTaken;
        enemiesTaken++;
        Destroy(other.gameObject);
        Debug.Log(fallenEnemy);
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        if (health == 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        int damage = collision.gameObject.GetComponent<Enemy>().damage;
        TakeDamage(damage);
    }
}
