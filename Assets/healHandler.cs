using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healHandler : MonoBehaviour
{
    public float healToGive;
    public bool healGiven;
    public playerStats playerHP;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 move;
    private float speed = 1f;
    void Start()
    {   
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        playerHP = FindObjectOfType<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        healToGive = playerHP.GetComponent<playerStats>().maxHP;
    }

    
    void FixedUpdate()
    {
        moveCharacter(move);
        Swarm();
    }

    void OnTriggerEnter2D(Collider2D collider)
{
    if (collider.gameObject.CompareTag("Player"))
    {
        if (!healGiven)
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in players)
            {
                player.GetComponent<health>().healHp(healToGive * 0.3f);
            }
            healGiven = true;
            Destroy(gameObject);
        }
    }
}

    void objectDestroy()
    {
        Destroy(gameObject);
    }

        private void Swarm()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        move = direction;

    }

    void moveCharacter(Vector2 direction){
    rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}
