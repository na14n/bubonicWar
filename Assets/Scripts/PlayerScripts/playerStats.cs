using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public int baseDamage = 5;
    public int hp = 100;
    public int xp;
    public int maxXP = 20;
    public int playerLvl = 1;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseXP(int amount)
    {
        xp += amount;
    }

}
