using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float knockbackForce = 10.0f;
    public bool knockedBack = false;
    public Vector2 knockbackDirection;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (knockedBack)
        {
            // Apply knockback force in the direction of the attacker
            rb2d.AddForce(knockbackDirection * knockbackForce);
        }
    }

    public void Knockback(Vector2 direction)
    {
        knockedBack = true;
        knockbackDirection = -(direction - new Vector2(this.transform.position.x, this.transform.position.y)).normalized;
        Invoke("offKnockBack", 0.5f);
    }

    public void offKnockBack()
    {
        knockedBack = false;
    }

}
