using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaserBullet : MonoBehaviour
{
    public float speed;
    public GameObject laserPrefab;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootLaser();
            //Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
        }
    }

    void ShootLaser()
    {
        Vector3 mousePos = Input.mousePosition;

        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, mousePos, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
