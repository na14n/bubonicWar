using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear : MonoBehaviour
{

    public float atkDamage = 7;
    public float characterDmg;
    public float atkSpeed = 1.5f;
    public static float lastAttackTime;
    public float attackRange = 3f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
    public float vector_2_x;
    public float vector_2_y;
    public GameObject Object;
    public Animator animatorComponent;

    void Start()
    {
        animatorComponent = Object.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        characterDmg = transform.parent.parent.parent.GetComponent<playerStats>().baseDamage;
        totalatk = characterDmg + atkDamage;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector2 attackRange = new Vector2(vector_2_x, vector_2_y);  // set attackRange.x to 2.0 and attackRange.y to 1.0
        Gizmos.DrawWireCube(transform.position, attackRange);
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (Time.time - spear.lastAttackTime > atkSpeed)
        {
            if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Guardian"))
            {
                animatorComponent.SetTrigger("spearAtk");
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                foreach (Collider2D enemy in enemiesInRange)
                {
                    if (enemy.gameObject.CompareTag("Enemy") || enemy.gameObject.CompareTag("Guardian"))
                    {
                        enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                        enemy.GetComponent<knockback>().Knockback();
                    }
                }
                spear.lastAttackTime = Time.time;
            }
        }
    }
}
