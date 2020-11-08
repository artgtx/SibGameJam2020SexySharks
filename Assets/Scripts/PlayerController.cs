using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private float horizontalInput;

    public int health = 5;
    public float energyVault = 1000;
    public float energyFromCarrier;
    private float gunCostLaser;
    private float gunCostPlasma;

    private GameObject carrier;
    public TextMeshProUGUI energyText;


    // Start is called before the first frame update
    void Start()
    {
        gunCostLaser = GetComponent<Gun>().energyCostLaser;
        gunCostPlasma = GetComponent<Gun>().energyCostPlasma;
        carrier = GameObject.FindGameObjectWithTag("Carrier");
        energyText.text = "Energey: " + energyVault;
    }

    // Update is called once per frame
    void Update()
    {
        energyFromCarrier = carrier.GetComponent<CarrierController>().energyTaken;
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
            UpdateEnergy(energyVault);
        }
        if(Input.GetMouseButton(0) && energyVault > 30)
        {  
            energyVault -= gunCostLaser;
            UpdateEnergy(energyVault);
        }
        if (Input.GetMouseButton(1) && energyVault > 90)
        {
            energyVault -= gunCostPlasma;
            UpdateEnergy(energyVault);
        }
    }

    private void UpdateEnergy(float energy)
    {

        energyText.text = "Energy: " + Mathf.Round(energy);
    }
}

