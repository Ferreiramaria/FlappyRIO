using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    bool isPaused;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }        
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
