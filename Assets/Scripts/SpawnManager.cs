using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRangeX = -15;

    private float startDelay = 1;
    private float spawnInterval = 3f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), transform.position.y, transform.position.z);

        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
}