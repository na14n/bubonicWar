using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpBarHandler : MonoBehaviour
{
    public xpBar xpBar;
    public GameObject playerStats;

    public float playerCurrentXP;
    public float playerXP;
    public float playerMaxXP;


    void Update()
    {   
        
        playerXP = playerStats.GetComponent<playerStats>().xp;
        playerMaxXP = playerStats.GetComponent<playerStats>().maxXP;

        playerCurrentXP = playerXP/playerMaxXP;
        
        
        xpBar.SetXp(playerCurrentXP);
    }
}
