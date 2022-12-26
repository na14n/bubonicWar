using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPData : MonoBehaviour
{   
    public int maxHP = 50;
    public int hp;
    public int damage = 5;

    public GameObject enemy;

        void Start()
    {
        
    }


        void Update()
    {
    }

    public void takeDamage(int amount)
    {
        this.hp -= amount;
        this.hp = Mathf.Clamp(hp - amount, 0, maxHP);
    }

    public void increaseMaxHP(int amount)
    {
        this.maxHP += amount;

    }

    public void healHP(int amount)
    {
        this.hp += amount;
        this.hp = Mathf.Clamp(hp + amount, 0, maxHP);
    }

}
