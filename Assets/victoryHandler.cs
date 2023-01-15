using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class victoryHandler : MonoBehaviour
{

    public levelLoader _levelLoader;

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
            
            Invoke("playerKilled", 1f);
            // _levelLoader.LoadGameOver();
        }
    }

    public void playerKilled()
    {
        _levelLoader.LoadGameOver();
    }
}
