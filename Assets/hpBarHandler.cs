using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpBarHandler : MonoBehaviour
{

    public healthBar hpBar;
    public GameObject playerStats;

    public float playerHP;
    public float playerMaxHP;
    public float playerCurrentHP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHP = playerStats.GetComponent<health>().hp;
        playerMaxHP = playerStats.GetComponent<playerStats>().maxHP;

        playerCurrentHP = playerHP/playerMaxHP;
        
        hpBar.SetSize(playerCurrentHP);
    }
}
