using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{   
    private GameObject attackArea = default;
    private float timetoAttack = 0.25f;
    private bool attacking = false;
    private float timer = 0f;
    
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();

        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timetoAttack);
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }


        }
    }

    private void Attack()
    {   
        attacking = true;
        attackArea.SetActive(attackArea);
    }
}
