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
            Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(plasmaPrefab, transform.position, plasmaPrefab.transform.rotation);
        }
    }
}

