using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public float speedM = 5f;
    public Rigidbody2D p1;
    public Rigidbody2D p2;

    Vector2 movement1;
    Vector2 movement2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Movement();
        player2Movement();
    }

    void FixedUpdate()
    {
        p1.MovePosition(p1.position + movement1 * speedM * Time.fixedDeltaTime);
        p2.MovePosition(p2.position + movement2 * speedM * Time.fixedDeltaTime);
    }

    void player1Movement()
    {
        movement1.x = Input.GetAxisRaw("Player 1 X");
        movement1.y = Input.GetAxisRaw("Player 1 Y");

        // Sprite Flip
        if (movement1.x > 0)
        {
            p1.transform.localScale = new Vector3(1,1,1);
        }

        if (movement1.x < 0)
        {
            p1.transform.localScale = new Vector3(-1,1,1);
        }
    }

    void player2Movement()
    {
        
        movement2.x = Input.GetAxisRaw("Player 2 X");
        movement2.y = Input.GetAxisRaw("Player 2 Y");  

        // Sprite Flip
        if (movement2.x > 0)
        {
            p2.transform.localScale = new Vector3(1,1,1);
        }

        if (movement2.x < 0)
        {
            p2.transform.localScale = new Vector3(-1,1,1);
        }
    }
}
