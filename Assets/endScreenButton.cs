using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreenButton : MonoBehaviour
{

    public levelLoader _levelLoader;

    public void ExitGame()
    {
        
        _levelLoader.LoadExitGame();
        Time.timeScale = 1;
    }

    public void Retry()
    {
        Debug.Log("retry");
        // SceneManager.LoadScene(0);
        _levelLoader.returnMenu();
        Time.timeScale = 1;
    }

}
