using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DreamEater : MonoBehaviour
{
    public AudioSource soundFX;
    public Text scoreText;
    public CollisionController collisionController;
    private bool soundPlayed;

    void Start()
    {
        soundPlayed = false;
        setScoreText();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("collectable"))
        {
            if (!soundPlayed)
            {
                soundFX.GetComponent<AudioSource>().Play(0);
                soundPlayed = true;
            }

            collider.gameObject.SetActive(false);
            collisionController.addScore(150);
            setScoreText();
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + collisionController.getScore().ToString() + " pts";
        soundPlayed = false;
    }
}
