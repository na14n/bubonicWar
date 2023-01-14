using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreenButton : MonoBehaviour
{

    public levelLoader _levelLoader;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        Debug.Log("retry");
        // SceneManager.LoadScene(0);
        _levelLoader.returnMenu();
    }

}
