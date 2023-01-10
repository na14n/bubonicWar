using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abominationScript : MonoBehaviour
{

    [SerializeField]
    public float damage = 5;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    public float hp;
    [SerializeField]
    public float maxHp;
    [SerializeField]
    private EnemyData data;
    [SerializeField]
    public float atkSpeed;
    [SerializeField]
    public Vector3 object1Transform;

    [SerializeField]
    public Vector3 object2Transform;
    [SerializeField]

    public GameObject[] enemies;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    float lastAttackTime;
    public playerStats playerStatx;
    public float playerLvl;
    private bool isAttacking = false;

    // Start is called before the first frame update

    void Awake()
    {
        playerStatx = FindObjectOfType<playerStats>();
        playerLvl = playerStatx.playerLvl;
        scaleEnemy();
    }
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        hp = maxHp;
        setEnemyValues();
    }

    void Update()
    {   
        float hp = GetComponent<health>().hp;

        if (hp <= maxHp * .3)
        {
            
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

        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = object1Transform;
        }
        else if (player.transform.position.x < transform.position.x)
        {
            transform.localScale = object2Transform;
        }
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void setEnemyValues()
    {
        GetComponent<health>().setHealth(data.maxHp + (playerLvl * 3), data.maxHp + (playerLvl * 3));
        damage = data.damage + (playerLvl * 2);
        speed = data.speed;
        atkSpeed = data.atkSpeed;
        object1Transform = data.object1Transform;
        object2Transform = data.object2Transform;
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(Attack(collider));
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            isAttacking = false;
            StopAllCoroutines();
        }
    }

    IEnumerator Attack(Collider2D collider)
    {
        while (true)
        {
            collider.GetComponent<health>().damage(damage, false);
            collider.GetComponent<knockback>().Knockback();
            Debug.Log("ATTACKED BAM");
            yield return new WaitForSeconds(atkSpeed);
        }
    }

    public void scaleEnemy()
    {
        maxHp = maxHp + (playerLvl * 2);
        damage = damage + (playerLvl * 2);
    }

    public void bossRage()
    {
        object1Transform = object1Transform * 1.5f;
        object2Transform = object2Transform * 1.5f;
        speed = speed + 1;
        damage = damage * 0.5f;
        GetComponent<health>().healHp(maxHp * .3f);
    }

}
