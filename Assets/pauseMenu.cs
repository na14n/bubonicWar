using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject openBtn;
    public GameObject closeBtn;
    bool isActive;


    private void Awake()
    {
        pausePanel.SetActive(false);
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
        isActive = false;

    }

    public void OpenPanel()
    {
        pausePanel.SetActive(true);
        openBtn.SetActive(false);
        closeBtn.SetActive(true);
        Time.timeScale = 0;
        isActive = true;
        
    }

    public void ClosePanel()
    {
        pausePanel.SetActive(false);
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
        Time.timeScale = 1;
        isActive = false;
    }

    void Update()
    {
        EscapeClose();
    }

    public void EscapeClose()
    {
        if (isActive == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OpenPanel();
            }
        }
        else if (isActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ClosePanel();
            }
        }
        
    }

}

