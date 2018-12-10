using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(sceneName: "Pinball");
    }

    public void Menu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }
}
