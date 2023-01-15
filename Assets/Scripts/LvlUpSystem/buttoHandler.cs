using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class buttoHandler : MonoBehaviour
{
    public GameObject panel;
    public GameObject playerStats;
    public float passiveHeal;
    public float speed;
    public int button1;
    public int button2;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public Button buttonx1;
    public Button buttonx2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
                
        if (button1 == 1)
        {
            text1.GetComponent<TextMeshProUGUI>().text = "Increase Attack";
        }

        else if (button1 == 2)
        {
            text1.GetComponent<TextMeshProUGUI>().text = "Increase Health";
        }

        else if (button1 == 3)
        {
            text1.GetComponent<TextMeshProUGUI>().text = "Increase Speed";
        }

        else if (button1 == 4)
        {
            text1.GetComponent<TextMeshProUGUI>().text = "Increase Regen Per Second";
        }



        if (button2 == 1)
        {
            text2.GetComponent<TextMeshProUGUI>().text = "Increase Attack";
        }

        else if (button2 == 2)
        {
            text2.GetComponent<TextMeshProUGUI>().text = "Increase Health";
        }

        else if (button2 == 3)
        {
            text2.GetComponent<TextMeshProUGUI>().text = "Increase Speed";
        }

        else if (button2 == 4)
        {
            text2.GetComponent<TextMeshProUGUI>().text = "Increase Regen Per Second";
        }

    }


    public void increaseAttack()
    {

    }

    public void increaseHealth()
    {

    }

    public void PassiveHeal()
    {


    }

    public void increaseMovementSpeed()
    {


    }

    public void lvlUpChoices(int but1, int but2)
    {
        button1 = but1;
        button2 = but2;
    }

    public void butChoice()
    {

        if (button1 == 1)
        {   

            playerStats.GetComponent<playerStats>().upgradeAttack(5, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button1 == 2)
        {   
            playerStats.GetComponent<playerStats>().upgradeHealth(20, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button1 == 3)
        {   
            playerStats.GetComponent<playerStats>().upgradeSpeed(0.15f, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button1 == 4)
        {   
            playerStats.GetComponent<playerStats>().upgradeHeal(0.5f, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void butChoice2()
    {
        if (button2 == 1)
        {   
            playerStats.GetComponent<playerStats>().upgradeAttack(5, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button2 == 2)
        {   
            playerStats.GetComponent<playerStats>().upgradeHealth(20, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button2 == 3)
        {   
            playerStats.GetComponent<playerStats>().upgradeSpeed(0.15f, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }

        else if (button2 == 4)
        {   
            playerStats.GetComponent<playerStats>().upgradeHeal(0.5f, true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
