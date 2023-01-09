using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablePasser : MonoBehaviour
{
    public static variablePasser instance;
    public int firstWep;
    public int secondWep;
    public static variablePasser Instance { get; private set; }

    void Awake() {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
    }

}
