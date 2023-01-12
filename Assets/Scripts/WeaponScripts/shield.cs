using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public float atkDamage = 3;
    public float characterDmg;
    public float atkSpeed = 1f;
    public static float lastAttackTime;
    public float attackRange = 4f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
    private float playerHP;
    private float lastheal;
    private int healpersec = 5;
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
        playerHP = transform.parent.parent.parent.GetComponent<health>().hp;
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
        transform.parent.parent.parent.GetComponent<health>().healHp(playerHP * 0.01f);
        Debug.Log("healing for everyone");
        lastheal = Time.time;  // update lastheal here
        yield return new WaitForSeconds(healpersec);
    }
}

void OnTriggerStay2D(Collider2D collider)
{
    if (Time.time - shield.lastAttackTime > atkSpeed)
    {
        if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Guardian"))
        {
            animatorComponent.SetTrigger("shieldAtk");
            Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
            foreach (Collider2D enemy in enemiesInRange)
            {
                if (enemy.gameObject.CompareTag("Enemy") || enemy.gameObject.CompareTag("Guardian"))
                {
                    enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                    enemy.GetComponent<knockback>().Knockback();
                }
            }
            shield.lastAttackTime = Time.time;
        }
    }
}

void OnDrawGizmosSelected()
{   
    Gizmos.color = Color.red;
    Vector2 attackRange = new Vector2(2f, 2.5f);  // set attackRange.x to 2.0 and attackRange.y to 1.0
    Gizmos.DrawWireCube(transform.position, attackRange);
}

}
