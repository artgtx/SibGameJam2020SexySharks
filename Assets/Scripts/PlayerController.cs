using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private float horizontalInput;

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
            transform.Translate(Vector3.right * speed * horizontalInput);
        }
    }
}

