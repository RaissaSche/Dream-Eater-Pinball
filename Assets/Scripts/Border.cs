using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    Rigidbody objRigidBody;

    void Start()
    {
        objRigidBody = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter()
    {
        objRigidBody.AddForce(-objRigidBody.velocity * Time.deltaTime);
    }
}
