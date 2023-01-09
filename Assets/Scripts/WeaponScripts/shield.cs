using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public float atkDamage = 3;
    public float characterDmg;
    public float atkSpeed = 1f;
    float lastAttackTime;
    public float attackRange = 4f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
    private float playerHP;
    private float lastheal;
    private int healpersec = 5;

    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        characterDmg = transform.parent.parent.GetComponent<playerStats>().baseDamage;
        totalatk = characterDmg + atkDamage;
        playerHP = transform.parent.parent.GetComponent<health>().hp;
    }

    void FixedUpdate()
    {
        if (Time.time - lastheal > healpersec)
        {
            StartCoroutine(HealOverTime());
            lastheal = Time.time;
        }
    }

IEnumerator HealOverTime()
{
    while (true)
    {
        transform.parent.parent.GetComponent<health>().healHp(playerHP * 0.01f);
        Debug.Log("healing for everyone");
        lastheal = Time.time;  // update lastheal here
        yield return new WaitForSeconds(healpersec);
    }
}

    void OnTriggerStay2D(Collider2D collider)
    {
            if (Time.time - lastAttackTime > atkSpeed)
            {
                if (collider.gameObject.CompareTag("Enemy"))
                {
                    Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                    foreach (Collider2D enemy in enemiesInRange)
                    {
                        if (enemy.gameObject.CompareTag("Enemy"))
                        {
                            enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                            enemy.GetComponent<knockback>().Knockback();
                        }
                    }
                    lastAttackTime = Time.time;
                }
            }
    }

void OnDrawGizmosSelected()
{   
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, attackRange);
}

}
