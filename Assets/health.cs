using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public GameObject dropWep1;
    public GameObject dropWep2;
    public float weaponNum;
    public int abominationSpawn;
    public GameObject damageIndicator;
    public GameObject healIndicator;
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
        if (amount <= 0)
        {
            throw new System.ArgumentException("cannot have negative damage");
        }

        bool wouldBeOverMaxHealth = hp + amount > maxHP;

        if (wouldBeOverMaxHealth)
        {
            this.hp = maxHP;
            
            GameObject healText = Instantiate(healIndicator, this.transform.position, Quaternion.identity);
            healIndicator.transform.GetChild(0).GetComponent<TextMeshPro>().text = amount.ToString();
            healIndicator.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(255,0,0);
        }

        else
        {
            this.hp += amount;
            
            GameObject healText = Instantiate(healIndicator, this.transform.position, Quaternion.identity);
            healIndicator.transform.GetChild(0).GetComponent<TextMeshPro>().text = amount.ToString();
            healIndicator.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(255,0,0);
        }
    }

    public void damage(float amount, bool damageReceive)
    {
        if (!damageReceive)
        {
            this.hp -= amount;
            this.gameObject.GetComponentInChildren<takeDamage>().TakeDamage();
            damageReceive = true;


            GameObject damageText = Instantiate(damageIndicator, this.transform.position, Quaternion.identity);
            damageText.transform.GetChild(0).GetComponent<TextMeshPro>().text = amount.ToString();
            damageText.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(255,0,0);
            if (this.hp <= 0)
            {
                Die();
                damageReceive = true;
            }
        }
    }

    public void Die()
    {
        if (weaponNum == 1)
        {
            GameObject droppedWep = Instantiate(dropWep1, this.transform.position, Quaternion.identity);
        }

        else if (weaponNum == 2)
        {
            GameObject droppedWep = Instantiate(dropWep2, this.transform.position, Quaternion.identity);
        }

        else
        {
            Debug.Log("not a guardian");
        }

        if (abominationSpawn == 1)
        {
            this.GetComponent<abominationScript>().abominationSpawn();
        }

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
