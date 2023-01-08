using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{   
    [SerializeField]
    public float hp = 100;
    private int maxHP = 100;
    public float knockbackForce = 10f;
    public int xpAmount;
    public float healpersec = 2f;
    public float lastheal;
    public GameObject xpPrefab;
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

    public void healHp(float amount)
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

    public void damage(int amount, bool damageReceive)
    {   
        Debug.Log("damage is called");
        if (!damageReceive)
        {
                this.hp -= amount;
                this.gameObject.GetComponentInChildren<takeDamage>().TakeDamage();
                damageReceive = true;

            if (this.hp <= 0)
            {
                Die();
                damageReceive = true;
            }
        }
    }

    public void Die()
    {   
            GameObject xp = Instantiate(xpPrefab, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("destroyed cuzz get killed");
    }


}
