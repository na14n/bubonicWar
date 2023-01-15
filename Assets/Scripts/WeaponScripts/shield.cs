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
    public static float lastheal;
    private int healpersec = 5;
    public float vector_2_x;
    public float vector_2_y;
    public float x_offset;
    public float y_offset;
    public float z_offset;
    public float z_rotation;
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
        playerHP = transform.parent.parent.parent.GetComponent<health>().hp;
    }

    void FixedUpdate()
    {
        if (Time.time - shield.lastheal > healpersec)
        {
            StartCoroutine(HealOverTime());
            shield.lastheal = Time.time;
        }
    }

IEnumerator HealOverTime()
{
    while (true)
    {
        transform.parent.parent.parent.GetComponent<health>().healHp(playerHP * 0.01f);
        Debug.Log("healing for everyone");
        shield.lastheal = Time.time;  // update lastheal here
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
                    collider.GetComponent<knockback>().Knockback(this.transform.position);
                }
            }
            soundPlayer.GetComponent<audioSourceAttack>().playAttack();
            shield.lastAttackTime = Time.time;
        }
    }
}

void OnDrawGizmosSelected()
{   
    Gizmos.color = Color.red;
    Vector3 rotation = new Vector3(0, 0, z_rotation);
    Vector3 position = new Vector3(x_offset, y_offset, z_offset);
    Vector3 scale = new Vector3(vector_2_x, vector_2_y, 1);
    Matrix4x4 matrix = Matrix4x4.TRS(transform.position + position, Quaternion.Euler(rotation), scale);
    Gizmos.matrix = matrix;
    Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
}

}
