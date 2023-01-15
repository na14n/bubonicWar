using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float knockbackForce = 10.0f;
    public bool knockedBack = false;
    public Vector2 knockbackDirection;
    private Vector2 lastKnockbackDirection;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void Knockback(Vector2 direction)
    {   
        if (direction != lastKnockbackDirection) {
        knockedBack = true;
        knockbackDirection = -(direction - new Vector2(this.transform.position.x, this.transform.position.y)).normalized;
        rb2d.AddForce(knockbackDirection * knockbackForce);
        Invoke("offKnockBack", 0.5f);
        Invoke("offKnockBack", 1f);
        }
    }

    public void offKnockBack()
    {
        knockedBack = false;
    }

}
