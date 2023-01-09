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
    public float playerLvl = 1;
    public float speed = 5f;
    public GameObject lvlUpPanel;
    public Enemy enemyStats;

    public GameObject wepPrefab1;
    public GameObject wepPrefab2;
    public GameObject wepPrefab3;
    public GameObject wepPrefab4;
    bool wepUnlocked = false;
    public GameObject wepHandler;
    public int wepTwoChoice;
    public GameObject wep1;
    public GameObject wep2;
    public GameObject wep3;
    public GameObject wep4;
    public GameObject wep5;
    public GameObject wep6;
    void Start()
    {
        this.GetComponent<health>().setHealth(hp,maxHP);
        enemyStats = FindObjectOfType<Enemy>();
        wepTwoChoice = variablePasser.Instance.secondWep;
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
            unlockWep();
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

    public void unlockWep()
    {   
        WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
        if (!wepUnlocked)
        {   
            Debug.Log("lvl up");
            if (playerLvl == 5)
            {   
                if (wepTwoChoice == 1)
        {
            weaponScript.AddNewWeapon(wep1);
        }

        else if (wepTwoChoice == 2)
        {
            weaponScript.AddNewWeapon(wep2);
        }
        
        else if (wepTwoChoice == 3)
        {
            weaponScript.AddNewWeapon(wep3);
        }

        else if (wepTwoChoice == 4)
        {
            weaponScript.AddNewWeapon(wep4);
        }

        else if (wepTwoChoice == 5)
        {
            weaponScript.AddNewWeapon(wep5);
        }

        else if (wepTwoChoice == 6)
        {
            weaponScript.AddNewWeapon(wep6);
        }

            }
        }
    }
}

