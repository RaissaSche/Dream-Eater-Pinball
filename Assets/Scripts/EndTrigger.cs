using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public AudioSource soundFX;
    private int count = 0;
    private bool soundPlayed;

    void OnTriggerEnter(Collider collider)
    {
        soundPlayed = false;

        if (!soundPlayed)
        {
            soundFX.GetComponent<AudioSource>().Play(0);
            soundPlayed = true;
        }

        collider.gameObject.SetActive(false);
        count++;

        if (count == 3)
        {
            SceneManager.LoadScene(sceneName: "EndGame");
        }
    }
}
