using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DreamEater : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        score = 0;
        setScoreText();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("collectable"))
        {
            collider.gameObject.SetActive(false);
            score += 150;
            setScoreText();
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString() + " pts";
    }
}
