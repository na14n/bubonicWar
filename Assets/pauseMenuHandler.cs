using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuHandler : MonoBehaviour
{

    public GameObject panel;
    public GameObject openBtn;
    public GameObject closeBtn;

    public bool isActive;


    private void Awake()
    {
        panel.SetActive(false);
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
        isActive = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (isActive == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                openPanel();
                Time.timeScale = 0;
            }
        }
        else if (isActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                closePanel();
                Time.timeScale = 1;
            }
        }
    }

    public void closePanel()
    {
        panel.SetActive(false);
        openBtn.SetActive(true);
        closeBtn.SetActive(false);
        isActive = false;
    }

    public void openPanel()
    {
        panel.SetActive(true);
        openBtn.SetActive(false);
        closeBtn.SetActive(true);
        isActive = true;
    }

}
