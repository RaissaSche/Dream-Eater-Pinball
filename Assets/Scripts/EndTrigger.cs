using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    private int count = 0;

    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.SetActive(false);
        count++;

        if(count == 3)
        {
            SceneManager.LoadScene(sceneName: "EndGame");
        }
    }
}
