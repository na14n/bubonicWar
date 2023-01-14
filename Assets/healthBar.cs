using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour
{

    public hpBar _healthBar;
    public GameObject playerStats;

    public float playerHP;
    public float playerMaxHP;
    public float playerCurrentHP;


    private void Start()
    {
        // _healthBar.SetSize(.4f);
        // player01 = 
    }


    private void Update()
    {
        playerHP = playerStats.GetComponent<health>().hp;
        playerMaxHP = playerStats.GetComponent<playerStats>().maxHP;

        playerCurrentHP = playerHP/playerMaxHP;
        Debug.Log(playerCurrentHP);

        _healthBar.SetSize(playerCurrentHP);
        
    }
}
