using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public int atkDamage = 3;
    public int characterDmg;
    public float atkSpeed = 5f;
    float lastAttackTime;
    public float attackRange = 1.3f;
    public GameObject[] enemies;
    public int totalatk;

    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {

        characterDmg = transform.parent.parent.GetComponent<playerStats>().baseDamage;
        totalatk = characterDmg + atkDamage;
    }

    void FixedUpdate(){
        
    }
void OnTriggerEnter2D(Collider2D collider)
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
                    enemy.GetComponent<health>().damage(atkDamage+ characterDmg);
                }
            }
            lastAttackTime = Time.time;
        }
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
                    enemy.GetComponent<health>().damage(atkDamage+ characterDmg);
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
