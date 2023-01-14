using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class statsUI : MonoBehaviour
{   
    public TextMeshProUGUI speed;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI atk;
    public TextMeshProUGUI regen;
    public TextMeshProUGUI Experience;
    public GameObject playerStats;

    public float playerSpeed;
    public float playerHeal;
    public float playerHP;
    public float playerMaxHP;
    public float playerATK;
    public float playerXP;
    public float playerMaxXP;
    public float playerLVL;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        playerHeal = playerStats.GetComponent<playerStats>().passiveHeal;
        playerSpeed = playerStats.GetComponent<playerStats>().speed;
        playerATK = playerStats.GetComponent<playerStats>().baseDamage;
        playerHP = playerStats.GetComponent<health>().hp;
        playerMaxHP = playerStats.GetComponent<playerStats>().maxHP;
        playerXP = playerStats.GetComponent<playerStats>().xp;
        playerMaxXP = playerStats.GetComponent<playerStats>().maxXP;
        playerLVL = playerStats.GetComponent<playerStats>().playerLvl;

        hp.GetComponent<TextMeshProUGUI>().text = playerHP + " / " + playerMaxHP;
        Experience.GetComponent<TextMeshProUGUI>().text = "Level: " + playerLVL + " XP: " + playerXP + " / " + playerMaxXP;
        speed.GetComponent<TextMeshProUGUI>().text = " " + playerSpeed;
        atk.GetComponent<TextMeshProUGUI>().text = " " + playerATK;
        regen.GetComponent<TextMeshProUGUI>().text = " " + playerHeal;
    }
}
