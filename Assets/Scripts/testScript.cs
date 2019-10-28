using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        //  Quaternion cubeRotation = Quaternion.Euler(0, 30, 0);
        //  rb.rotation = cubeRotation;
    }

    void Update()
    {   
        //  rb.velocity = new Vector3(0.0f, 0.0f, 2.0f);
        rb.velocity = transform.TransformDirection(new Vector3(0, 0, 2.0f));

        //  rb.velocity = Vector3.forward * Time.deltaTime;
    }
}
