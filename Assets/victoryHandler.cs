using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class victoryHandler : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;
    void Start()
    {
        victoryScreen.SetActive(false);
        defeatScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        GameObject[] remainingEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");

        if (remainingEnemies.Length == 0)
        {
            if (PlayerPrefs.GetInt("Abomination") == 1)
            {
                PlayerPrefs.SetInt("Abomination", 0);
                victoryScreen.SetActive(true);
                Invoke("pauseGame", 0.2f);
            }
        }

        if (player.Length == 0)
        {
                defeatScreen.SetActive(true);
                Invoke("pauseGame", 0.2f);
        }

    }

    public void abominationKilled()
    {
        PlayerPrefs.SetInt("Abomination", 0);
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
    }

    public void buttonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
