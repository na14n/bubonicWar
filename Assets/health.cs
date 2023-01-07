using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{   
    [SerializeField]
    public int hp = 100;
    private int maxHP = 100;
    public float knockbackForce = 10f;
    public int xpAmount;
    public GameObject xpPrefab;
    
    public bool isDead = false;
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

    public void Die()
    {   
        // Instantiate the XP drop at the same position as the mob
        GameObject xp = Instantiate(xpPrefab, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("destroyed cuzz get killed");
    }

    public void increaseXP(int amount)
    {
        xpAmount += amount;
    }


}
