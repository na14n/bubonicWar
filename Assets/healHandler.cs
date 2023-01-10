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
    public float followSpeed = 7.0f;
    public float followDistance = 3.0f;
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

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < followDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * followSpeed * Time.deltaTime, Space.World);
        }
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
                    player.GetComponent<health>().healHp(healToGive * 0.1f);
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
}
