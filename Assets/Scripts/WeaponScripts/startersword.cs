using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startersword : MonoBehaviour
{
    public float atkDamage = 2;
    public float characterDmg;
    public float atkSpeed = 0.3f;
    public static float lastAttackTime;
    public float attackRange = 2f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;
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

    void OnTriggerStay2D(Collider2D collider)
    {
        if (Time.time - startersword.lastAttackTime > atkSpeed)
        {
            if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Guardian"))
            {
                animatorComponent.SetTrigger("swordAtk");
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                foreach (Collider2D enemy in enemiesInRange)
                {
                    if (enemy.gameObject.CompareTag("Enemy") || enemy.gameObject.CompareTag("Guardian"))
                    {
                        Debug.Log(atkDamage+characterDmg);
                        enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                        enemy.GetComponent<knockback>().Knockback();
                    }
                }
                soundPlayer.GetComponent<audioSourceAttack>().playAttack();
                startersword.lastAttackTime = Time.time;
            }
        }
    }

}
