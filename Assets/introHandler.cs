using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introHandler : MonoBehaviour
{

    public GameObject transition;
    public Animator transitionComponent;

    // Start is called before the first frame update
    void Start()
    {
        transitionComponent = transition.GetComponent<Animator>();
        StartCoroutine(startTransition());
    }

    IEnumerator MainMenu()
    {
        yield return new WaitForSeconds(8f);
    }

    IEnumerator startTransition()
    {
        yield return new WaitForSeconds(8f);
        transition.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }


}
