using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
public float knockbackForce = 10.0f;
public bool knockedBack = false;

private Rigidbody2D rb2d;

void Start()
{
    rb2d = GetComponent<Rigidbody2D>();
}

void Update()
{
    if (knockedBack)
    {
        // Apply knockback force in the opposite direction
        rb2d.AddForce(transform.up * -knockbackForce);
    }
}

public void Knockback()
{
    knockedBack = true;
    Invoke("offKnockBack", 1f);
}


public void offKnockBack()
{
    knockedBack = false;
}

}
