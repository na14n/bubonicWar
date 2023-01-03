using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{   
    [SerializeField]
    private int hp = 100;
    private int maxHP = 100;

    public float knockbackForce = 10f;


    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
    
    public void setHealth(int maxHealth, int health)
    {
        this.maxHP = maxHealth;
        this.hp = health;
    }

    public void healHp(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentException("cannot have negative damage");
        }

        bool wouldBeOverMaxHealth = hp + amount > maxHP;

        if (wouldBeOverMaxHealth)
        {
            this.hp = maxHP;
        }

        else
        {
            this.hp += amount;
        }
    }

    public void damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentException("cannot have negative damage");
        }

            this.hp -= amount;
            this.gameObject.GetComponentInChildren<takeDamage>().TakeDamage();

        if (this.hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Debug.Log("destroyed cuzz get killed");
    }


}
