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
    public float passiveHeal = 0;

    public GameObject wepPrefab1;
    public GameObject wepPrefab2;
    public GameObject wepPrefab3;
    public GameObject wepPrefab4;
    bool wepUnlocked = false;
    public GameObject wepHandler;
    public int wepTwoChoice;
    public GameObject buttonHandler;
    public GameObject wep1;
    public GameObject wep2;
    public GameObject wep3;
    public GameObject wep4;
    public GameObject wep5;
    public GameObject wep6;
    public float healInterval = 1f;
    public int wepNum1 = 0;
    public int wepNum2 = 0;
    private float lastHealTime;
    void Start()
    {
        this.GetComponent<health>().setHealth(hp, maxHP);
        enemyStats = FindObjectOfType<Enemy>();
        wepTwoChoice = variablePasser.Instance.secondWep;
    }

    // Update is called once per frame
    void Update()
    {
        lvlUp();
        if (Time.time > lastHealTime + healInterval)
        {
            lastHealTime = Time.time;
            passiveHealing();
        }

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
            maxXP = (maxXP * 0.3f) + maxXP ;
            unlockWep();
            wepNum1 = Random.Range(1, 5);
            wepNum2 = Random.Range(1, 5);
            while (wepNum2 == wepNum1)
            {
                wepNum2 = Random.Range(1, 4);
            }
            lvlUpPanel.SetActive(true);
            buttonHandler.GetComponent<buttoHandler>().lvlUpChoices(wepNum1, wepNum2);
            Time.timeScale = 0;
            xp = 0;
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

    public void upgradeHealth(float amount, bool status = false)
    {
        if (status == true)
        {
            maxHP = maxHP + amount;
            this.GetComponent<health>().setMaxHp(maxHP);
            status = false;
        }

    }

    public void upgradeSpeed(float amount, bool status = false)
    {
        if (status == true)
        {
            speed = speed + amount;
            status = false;
        }
    }

    public void upgradeHeal(float amount, bool status = false)
    {
        if (status == true)
        {
            passiveHeal = passiveHeal + amount;
            status = false;
        }
    }

    public void passiveHealing()
    {
        this.GetComponent<health>().healHp(passiveHeal);
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

