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

    void Awake() {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
    }

    public void Reset(){
        panel.SetActive(false);
        firstWep = 0;
        secondWep = 0;
    }

}
