using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_atk : MonoBehaviour
{

    public float atkSpeed = 1f;
    float timer;
    public Vector3 movementVector;

    playerMovement playerMove;
 
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    public GameObject leftdown;
    public GameObject rightdown;
    public GameObject upright;
    public GameObject upleft;



    private void Awake()
    {
        playerMove = GetComponentInParent<playerMovement>();
    }

    void Start()
    {
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(false);
        leftdown.SetActive(false);
        rightdown.SetActive(false);
        upright.SetActive(false);
        upleft.SetActive(false);
    }

    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");


        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }

        
    }

    private void Attack(){
        Debug.Log("atk");
        timer = atkSpeed;

         if(playerMove.movement1.x > 0)
         {
            left.SetActive(true);
         }
         else {
            right.SetActive(true);
         }
    }
    
    
}
