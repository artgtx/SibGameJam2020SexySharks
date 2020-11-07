using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarrierController : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject fallenEnemy;

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
        Vector3 fallenEnemyPos = fallenEnemy.transform.position;

        if(fallenEnemy)
        {
            agent.SetDestination(fallenEnemyPos);
            
        }

        fallenEnemy = GameObject.FindGameObjectWithTag("Fallen Enemy");
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log(fallenEnemy);
    }
}
