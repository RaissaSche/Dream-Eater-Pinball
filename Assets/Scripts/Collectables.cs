using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public Transform collectable;
    public float targetTime = 5.0f;

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        float x = Random.Range(-16.0f, -8.0f);
        float z = Random.Range(-3.0f, 1.0f);

        Instantiate(collectable, new Vector3(x, -1.9f, z), Quaternion.identity);

        targetTime = 5.0f;
    }
}

