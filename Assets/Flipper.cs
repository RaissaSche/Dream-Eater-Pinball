using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public KeyCode key;
    Rigidbody objRigidBody;
    Vector3 objPosition;
    int contadorTrigger;

    void Start()
    {
        objRigidBody = GetComponent<Rigidbody>();
        objPosition = objRigidBody.position;
        contadorTrigger = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(key) && objRigidBody.isKinematic == true)
        {
            objRigidBody.constraints = RigidbodyConstraints.FreezePositionZ;
            objRigidBody.useGravity = true;
            objRigidBody.isKinematic = false;
            objRigidBody.AddRelativeForce(-800, 0, 0);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        contadorTrigger++;

        if(contadorTrigger == 1)
        {
            objRigidBody.AddRelativeForce(800, 0, 0);
        }
        else if(contadorTrigger == 2)
        {
            contadorTrigger = 0;
            objRigidBody.isKinematic = true;
        }
    }
}
