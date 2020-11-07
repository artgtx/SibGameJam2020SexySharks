using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    public GameObject plasmaPrefab;
    public GameObject laserPrefab;
    public int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(transform.position.x < 13 && transform.position.x > -13)
        {
            transform.Translate(Vector3.left * speed * horizontalInput);
        }



        if (Input.GetMouseButtonDown(0))
        {
            ShootLaser();
            //Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootPlasma();
            //Instantiate(plasmaPrefab, transform.position, plasmaPrefab.transform.rotation);
        }
    }

    void ShootLaser()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
        }
    }

    void ShootPlasma()
    {

    }
}

