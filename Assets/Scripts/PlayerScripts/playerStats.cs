using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public float baseDamage = 5;
    public float hp = 100;
    public float maxHP = 100;
    public int xp;
    public float maxXP = 100f;
    public float playerLvl = 5;
    public float speed = 5f;
    public GameObject lvlUpPanel;
    public Enemy enemyStats;
    void Start()
    {
        this.GetComponent<health>().setHealth(hp,maxHP);
        enemyStats = FindObjectOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        lvlUp();

    }

    public void increaseXP(int amount, bool status)
    {   
        if (!status)
        {
            xp += amount;
            status = true;
        }

    }

    public void lvlUp()
    {
            if (xp >= maxXP)
        {
            playerLvl = playerLvl + 1;
            maxXP = maxXP + 150 * 1.5f;
            lvlUpPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void upgradeAttack(int amount, bool status = false)
    {   
        if (status == true)
        {
            baseDamage = baseDamage + amount;
            status = false;
        }
    }

    public void upgradeHealth(int amount, bool status = false)
    {   
        if (status == true)
        {   
            maxHP = maxHP + amount;
            this.GetComponent<health>().setMaxHp(maxHP);
            status = false;
        }

    }

}
