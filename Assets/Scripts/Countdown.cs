using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public Text countdownText;
    public float duration;
    public float timeRemaining;
    public bool isCountingDown;

    void Start()
    {
        duration = 11800.0f * Time.deltaTime;
        isCountingDown = false;
        Begin();
        SetCountdownText();
    }

    void Update()
    {
        SetCountdownText();
        _tick();
    }

    void Begin()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("_tick", 1f);
        }
    }

    void _tick()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining > 0)
        {
            Invoke("_tick", 1f);
        }
        else
        {
            isCountingDown = false;
            SceneManager.LoadScene(sceneName: "EndGame");
        }
    }

    void SetCountdownText()
    {
        countdownText.text = timeRemaining.ToString();
    }
}
