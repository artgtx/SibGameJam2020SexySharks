using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelRotation : MonoBehaviour
{
    public Transform turel;
    public float rotationSpeed;
    float rotationAngle;

    // Update is called once per frame
    void Update()
    {
        RotateTurel();
    }

    void RotateTurel()
    {
        rotationAngle += Input.GetAxis("Mouse X") * rotationSpeed * -Time.deltaTime;
        rotationAngle = Mathf.Clamp(rotationAngle, 0, 180);
        turel.localRotation = Quaternion.AngleAxis(rotationAngle, Vector3.up);
    }
}
