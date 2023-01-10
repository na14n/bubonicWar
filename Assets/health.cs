using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField]
    public float hp = 100;
    public float maxHP = 100;
    public float knockbackForce = 10f;
    public int xpAmount;
    public float healpersec = 2f;
    public float lastheal;
    public GameObject xpPrefab;
    public GameObject healPrefab;
    public playerStats maxHPCurrently;
    public float currentMaxHP;
    void Start()
    {
        maxHPCurrently = FindObjectOfType<playerStats>();
    }


    // Update is called once per frame
    void Update()
    {
        hp = Mathf.Clamp(hp, 0, maxHP);
        currentMaxHP = maxHPCurrently.GetComponent<playerStats>().maxHP;
    }

    public void setHealth(float maxHealth, float health)
    {
        this.maxHP = maxHealth;
        this.hp = health;
    }

    public void setMaxHp(float amount)
    {
        this.maxHP = amount;
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

    public void damage(float amount, bool damageReceive)
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

        int randomNumber = Random.Range(1, 20);

        if (randomNumber >= 19)
        {
            GameObject heal = Instantiate(healPrefab, this.transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
        Debug.Log("destroyed cuzz get killed");


    }


}
