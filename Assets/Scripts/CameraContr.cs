using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContr : MonoBehaviour
{
    public Transform target;
    public float speed = 0.12f;
    public Vector3 offset;


   
    void Update()
    {
        Vector3 desiredPost = target.position + offset;
        Vector3 smoothPost = Vector3.Lerp(transform.position, desiredPost, speed);
        transform.position = smoothPost;
    }
}
