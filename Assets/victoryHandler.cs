using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class victoryHandler : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] remainingEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        
        if (player.Length == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void abominationKilled()
    {
        PlayerPrefs.SetInt("Abomination", 0);
    }
}
