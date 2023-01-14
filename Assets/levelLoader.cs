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
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    public void LoadNextlevel()
    {   
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        transition.SetTrigger("start");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {   
        soundHandler.GetComponent<audioSourceMainMenu>().playButton();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
