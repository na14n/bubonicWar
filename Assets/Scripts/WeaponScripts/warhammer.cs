using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warhammer : MonoBehaviour
{
    public float atkDamage = 7;
    public float characterDmg;
    public float atkSpeed = 1f;
    public static float lastAttackTime;
    public float attackRange = 2f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
    public GameObject Object;
    public Animator animatorComponent;
    public GameObject soundPlayer;


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

    void OnTriggerStay2D(Collider2D collider)
    {
        if (Time.time - warhammer.lastAttackTime > atkSpeed)
        {
            if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Guardian"))
            {
                animatorComponent.SetTrigger("hammerAtk");
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                foreach (Collider2D enemy in enemiesInRange)
                {
                    if (enemy.gameObject.CompareTag("Enemy") || enemy.gameObject.CompareTag("Guardian"))
                    {
                        enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                        enemy.GetComponent<knockback>().Knockback();
                    }
                }
                warhammer.lastAttackTime = Time.time;
                soundPlayer.GetComponent<audioSourceAttack>().playAttack();
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }


}
