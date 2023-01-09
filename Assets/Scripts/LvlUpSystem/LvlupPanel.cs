using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void lvlupPop()
    {
        panel.SetActive(true);
    }
}
