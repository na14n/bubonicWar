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
    // bool wepUnlocked = false;
    // public GameObject wepHandler;
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
            // unlockWep();
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

// public void unlockWep()
// {
//     if (!wepUnlocked)
//     {   
//         Debug.Log("lvl up");
//         if (playerLvl == 3)
//         {   
//             Debug.Log("weapon unlocked");
//             GameObject warhammer = Instantiate(wepPrefab1, wepHandler.transform);
//             wepUnlocked = true;
//             WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
//             weaponScript.weapons[weaponScript.totalWeapons] = warhammer;
//             weaponScript.totalWeapons++;
//             weaponScript.UpdateWeaponsArray();
//             warhammer.SetActive(false);
//         }

//         if (playerLvl == 6)
//         {
//             GameObject spear = Instantiate(wepPrefab2, wepHandler.transform);
//             wepUnlocked = true;
//             // Add the spear game object to the weapons array
//             WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
//             weaponScript.weapons[weaponScript.totalWeapons] = spear;
//         }

//         if (playerLvl == 9)
//         {
//             GameObject doubledagg = Instantiate(wepPrefab3, wepHandler.transform);
//             wepUnlocked = true;
//             // Add the doubledagg game object to the weapons array
//             WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
//             weaponScript.weapons[weaponScript.totalWeapons] = doubledagg;
//             weaponScript.totalWeapons++;
//         }

//         if (playerLvl == 12)
//         {
//             GameObject axe = Instantiate(wepPrefab4, wepHandler.transform);
//             wepUnlocked = true;
//             // Add the axe game object to the weapons array
//             WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
//             weaponScript.weapons[weaponScript.totalWeapons] = axe;
//             weaponScript.totalWeapons++;
//         }
//     }
// }

}

