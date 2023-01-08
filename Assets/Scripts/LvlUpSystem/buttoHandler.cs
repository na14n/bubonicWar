using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoHandler : MonoBehaviour
{
    public GameObject panel;
    public GameObject playerStats;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void increaseAttack()
    {   
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeAttack(5, true);
    }

    
    public void increaseHealth()
    {   
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeHealth(20, true);
    }
}
