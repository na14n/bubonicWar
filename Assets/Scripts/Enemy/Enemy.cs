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
    public int hp;
    [SerializeField]
    public int maxHp;
    [SerializeField]
    private EnemyData data;
    [SerializeField]
    public float atkSpeed;
    [SerializeField]
    public Vector3 object1Transform;

    [SerializeField]
    public Vector3 object2Transform;

    public GameObject[] enemies;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    float lastAttackTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        hp = maxHp;   
        setEnemyValues();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<health>().damage(5);
            Debug.Log("kill");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter(movement);
        Swarm();

    }

    private void Swarm()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;

        if(player.transform.position.x > transform.position.x)
        {
            transform.localScale = object1Transform;   
        }
        else if(player.transform.position.x < transform.position.x)
        {
            transform.localScale = object2Transform;
        }
    }

    void moveCharacter(Vector2 direction){
    rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void setEnemyValues()
    {
        GetComponent<health>().setHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
        atkSpeed = data.atkSpeed;
        object1Transform = data.object1Transform;
        object2Transform = data.object2Transform;
    }


void OnTriggerEnter2D(Collider2D collider)
{
    if (Time.time - lastAttackTime > atkSpeed)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<health>().damage(damage);
            }
            lastAttackTime = Time.time;
        }
    }
}

void OnTriggerStay2D(Collider2D collider)
{
    if (Time.time - lastAttackTime > atkSpeed)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject enemy in enemies)
            {
                enemy.GetComponent<health>().damage(damage);
            }
            lastAttackTime = Time.time;
        }
    }
}


}
