using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private float horizontalInput;

    public int health = 5;
    private float energyVault = 100;
    public float energyFromCarrier;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyFromCarrier = GameObject.FindGameObjectWithTag("Carrier").GetComponent<CarrierController>().energyTaken;
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * horizontalInput);

        if(energyFromCarrier > 0)
        {
            energyVault += energyFromCarrier;
            energyFromCarrier = 0;
            Debug.Log(energyVault);

        }
        
    }
}

