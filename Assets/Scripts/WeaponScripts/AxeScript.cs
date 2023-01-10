using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeScript : MonoBehaviour
{
    public float atkDamage = 3;
    public float characterDmg;
    public float atkSpeed = 1f;
    float lastAttackTime;
    public float attackRange = 3f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
    public GameObject Object;
    public Animator animatorComponent;

    void Start()
    {   
        animatorComponent = Object.GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {

        characterDmg = transform.parent.parent.GetComponent<playerStats>().baseDamage;
        totalatk = characterDmg + atkDamage;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
            if (Time.time - lastAttackTime > atkSpeed)
            {
                if (collider.gameObject.CompareTag("Enemy"))
                {
                    animatorComponent.SetTrigger("axeAtk");
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
