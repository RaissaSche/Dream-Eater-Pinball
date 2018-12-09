using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamEater : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("collectable"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}
