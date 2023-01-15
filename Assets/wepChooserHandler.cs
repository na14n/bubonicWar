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
    public int unlockScythe;
    public int unlockKatana;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;
    public Button btn8;
    public GameObject panel;

    public GameObject katanaSprite;
    public GameObject katanaBlacked;
    public GameObject scytheSprite;
    public GameObject scytheBlacked;

    public GameObject soundHandler;

    void Start()
    {

        unlockScythe = PlayerPrefs.GetInt("Katana");
        unlockKatana = PlayerPrefs.GetInt("Scythe");

        if (unlockKatana == 0)
        {
            btn7.interactable = false;
            katanaSprite.SetActive(false);
            katanaBlacked.SetActive(true);

        }
        else
        {
            katanaBlacked.SetActive(false);
        }

        if (unlockScythe == 0)
        {
            btn8.interactable = false;
            scytheSprite.SetActive(false);
            scytheBlacked.SetActive(true);
        }
        else
        {
            scytheBlacked.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        if (buttonClick >= 2)
        {
            // SceneManager.LoadScene(1);
            // panel.SetActive(true);
        }
    }

    public void swordBtn()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }
        buttonClick++;
        btn1.interactable = false;
    }

    public void SpearBtn()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn2.interactable = false;
    }

    public void shieldBtn()
    {
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn3.interactable = false;
    }

    public void daggerBtn()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn4.interactable = false;
    }

    public void axeBtn()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn5.interactable = false;
    }

    public void warHamBtn()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
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
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn6.interactable = false;
    }

    public void katana()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
        this.gameObject.SetActive(false);
        if (buttonClick == 0)
        {
            wep1 = 7;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 7;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn7.interactable = false;
    }

    public void Scythe()
    {   
        soundHandler.GetComponent<audioSourceMainMenu2>().playButton();
        this.gameObject.SetActive(false);

        if (buttonClick == 0)
        {
            wep1 = 8;
            variablePasser.Instance.firstWep = wep1;
        }

        if (buttonClick == 1)
        {
            wep2 = 8;
            closeAllBtn();
            variablePasser.Instance.secondWep = wep2;
            panel.SetActive(true);
            // SceneManager.LoadScene(1);
        }

        buttonClick++;
        btn8.interactable = false;
    }

    public void closeAllBtn()
    {   
        
        btn1.interactable = false;
        btn2.interactable = false;
        btn3.interactable = false;
        btn4.interactable = false;
        btn5.interactable = false;
        btn6.interactable = false;
        btn7.interactable = false;
        btn8.interactable = false;
    }

    public void openAllBtn()
    {
        buttonClick = 0;
        btn1.interactable = true;
        btn2.interactable = true;
        btn3.interactable = true;
        btn4.interactable = true;
        btn5.interactable = true;
        btn6.interactable = true;

        if (unlockKatana == 0)
        {
            btn7.interactable = false;
        }
        else
        {
            btn7.interactable = true;
            katanaSprite.SetActive(true);
        }

        if (unlockScythe == 0)
        {
            btn8.interactable = false;
        }
        else
        {
            btn8.interactable = true;
            scytheSprite.SetActive(true);
            
        }
    }
}
