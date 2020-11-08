using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private float horizontalInput;

    public int health = 5;
    public float energyVault = 1000;
    public float energyFromCarrier;
    private float gunCostLaser;
    private float gunCostPlasma;


    // Start is called before the first frame update
    void Start()
    {
        gunCostLaser = GetComponent<Gun>().energyCostLaser;
        gunCostPlasma = GetComponent<Gun>().energyCostPlasma;
    }

    // Update is called once per frame
    void Update()
    {
        energyFromCarrier = GameObject.FindGameObjectWithTag("Carrier").GetComponent<CarrierController>().energyTaken;
        horizontalInput = Input.GetAxis("Horizontal");

       // print(horizontalInput);
        if (transform.position.x <= 14.47&&transform.position.x >= -12.14)
        {
            transform.Translate(Vector3.right * speed * horizontalInput);
        }
        else if(transform.position.x <= -12.14&&horizontalInput<0)
        {
            transform.Translate(Vector3.right * speed * horizontalInput);
        }
        else if(transform.position.x >= 14.47&&horizontalInput>0)
        {
            transform.Translate(Vector3.right * speed * horizontalInput);
        }
       

        

        if(energyFromCarrier > 0)
        {
            energyVault = energyVault + (energyFromCarrier * Time.deltaTime);

            Debug.Log(energyVault);
        }
        if(Input.GetMouseButton(0) && energyVault > 30)
        {
            Debug.Log("Before shot:" + energyVault);
            energyVault -= gunCostLaser;
            Debug.Log("After shot:" + energyVault);
        }
        if (Input.GetMouseButton(1) && energyVault > 90)
        {
            Debug.Log("Before shot:" + energyVault);
            energyVault -= gunCostPlasma;
            Debug.Log("After shot:" + energyVault);
        }
    }
}

