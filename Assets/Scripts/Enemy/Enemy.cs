using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private int hp;
    private EnemyData data;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = FindObjectOfType<playerMovement>().transform;    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter(movement);
        Swarm();
        Die();
    }

    private void Swarm()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;

        if(player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1,1,1);   
        }
        else if(player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }

    void moveCharacter(Vector2 direction){
    rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    void Die()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
