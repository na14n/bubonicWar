using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public int baseDamage = 5;
    public int hp = 100;
    public int xp;
    public float maxXP = 100f;
    public int playerLvl = 1;
    public float speed = 5f;
    void Start()
    {
        
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
            maxXP = maxXP + 100 * 1.5f;
        }
    }

}
