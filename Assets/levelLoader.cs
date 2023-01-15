using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{

    public Animator transition;
    public GameObject soundHandler;

    public float transitionTime = 1f;

    public void LoadPreviouslevel()
    {   
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        transition.SetTrigger("start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    public void LoadNextlevel()
    {   
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        transition.SetTrigger("start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void returnMenu()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        transition.SetTrigger("start");
        StartCoroutine(LoadMainMenu());
    }

    public void LoadGameOver()
    {
        transition.SetTrigger("start");
        StartCoroutine(LoadDefeat());
    }

    public void LoadGameOverWin()
    {
        transition.SetTrigger("start");
        StartCoroutine(LoadVictory());
    }

    public void LoadExitGame()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        transition.SetTrigger("start");
        StartCoroutine(LoadExit());
    }


     public IEnumerator LoadExit()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        Application.Quit();
    }



    public IEnumerator LoadDefeat()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(4);
    }

    public IEnumerator LoadVictory()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(5);
    }


    public IEnumerator LoadMainMenu()
    {
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(0);
    }

    public IEnumerator LoadLevel(int levelIndex)
    {   
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
