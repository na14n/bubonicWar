using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class XPHandler : MonoBehaviour
{
    [SerializeField]
    private int xpToGive;
    [SerializeField]
    private XPDATA data;

    public Transform player;
    private Rigidbody2D rb;
    public float followSpeed = 15f;
    public float followDistance = 5f;
    bool xpGiven = false;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        xpToGive = data.xpToGive;
        Debug.Log("total xp:" + xpToGive);
    }

    // Update is called once per frame
    void Update()
    {
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
            if (!xpGiven)
            {
                GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
                foreach (GameObject player in players)
                {
                    player.GetComponent<playerStats>().increaseXP(xpToGive, false);
                }
                xpGiven = true;
                Destroy(gameObject);
            }
        }
    }

    void objectDestroy()
    {
        Destroy(gameObject);
    }

}
