using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LvlupPanel : MonoBehaviour
{   
    public GameObject panel;
    void Awake()
    {
        panel.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lvlupPop(int wep1, int wep2)
    {
        panel.SetActive(true);
    }
}
