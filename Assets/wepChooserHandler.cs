using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wepChooserHandler : MonoBehaviour
{   
    public int buttonClick;
    public int wep1;
    public int wep2;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
                if (buttonClick >= 2)
            {   
                SceneManager.LoadScene(2);
            }
    }

    public void swordBtn()
    {
        this.gameObject.SetActive(false);
        if (buttonClick == 0)
        {
            wep1 = 1;
            variablePasser.Instance.firstWep = wep1;
        }

            if (buttonClick == 1)
        {
            wep2 = 1;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }
        buttonClick++;
        btn1.interactable = false;
    }

    public void SpearBtn()
    {
        this.gameObject.SetActive(false);
        
        if (buttonClick == 0)
        {
            wep1 = 2;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 2;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }

        buttonClick++;
        btn2.interactable = false;
    }

    public void shieldBtn()
    {
        this.gameObject.SetActive(false);
        
        if (buttonClick == 0)
        {
            wep1 = 3;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 3;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }

        buttonClick++;
        btn3.interactable = false;
    }

        public void daggerBtn()
    {
        this.gameObject.SetActive(false);
        
        if (buttonClick == 0)
        {
            wep1 = 4;
            variablePasser.Instance.firstWep = wep1;
            
        }

        if (buttonClick == 1)
        {
            wep2 = 4;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }
        
        buttonClick++;
        btn4.interactable = false;
    }

        public void axeBtn()
    {
        this.gameObject.SetActive(false);
        
        if (buttonClick == 0)
        {
            wep1 = 5;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 5;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }
        
        buttonClick++;
        btn5.interactable = false;
    }

        public void warHamBtn()
    {
        this.gameObject.SetActive(false);
        
        if (buttonClick == 0)
        {
            wep1 = 6;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 6;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            SceneManager.LoadScene(2);
        }
        
        buttonClick++;
        btn6.interactable = false;
    }

    public void closeAllBtn()
    {
        btn1.interactable = false;
        btn2.interactable = false;
        btn3.interactable = false;
        btn4.interactable = false;
        btn5.interactable = false;
        btn6.interactable = false;
    }


}
