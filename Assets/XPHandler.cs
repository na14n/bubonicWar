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
    private Vector2 move;
    private float speed = 1f;
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
        
    }

        void FixedUpdate()
    {
        moveCharacter(move);
        Swarm();

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
