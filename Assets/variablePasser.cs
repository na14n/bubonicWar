using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablePasser : MonoBehaviour
{
    public static variablePasser instance;
    public int firstWep;
    public int secondWep;
    public static variablePasser Instance { get; private set; }
    public GameObject panel;
    public GameObject soundHandler;


    void Awake() {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
    }

    public void Reset(){
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
        panel.SetActive(false);
        firstWep = 0;
        secondWep = 0;
    }

}
