using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class samuraiGuardian : MonoBehaviour
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
    float lastAttackTime;
    public playerStats playerStatx;
    public float playerLvl;
    public float playerDMG;
    private bool isAttacking = false;
    public int dropWep;
    public float followDistance = 10f;
    public GameObject otherGuardian;

    // Start is called before the first frame update

    void Awake()
    {
        playerStatx = FindObjectOfType<playerStats>();
        playerLvl = playerStatx.playerLvl;
        playerDMG = playerStatx.baseDamage;
    }
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        hp = maxHp;
        scaleEnemy();
        setEnemyValues();
        this.GetComponent<AIDestinationSetter>().target = player;
    }

    void Update()
    {   
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = object1Transform;
        }
        else if (player.transform.position.x < transform.position.x)
        {
            transform.localScale = object2Transform;
        }

                float distance = Vector3.Distance(transform.position, player.position);
        if (distance < followDistance)
        {
            this.GetComponent<AIPath>().enabled = true;
        }

        else 
        {
            this.GetComponent<AIPath>().enabled = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    // private void Swarm()
    // {
    //     Vector3 direction = player.position - transform.position;
    //     float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //     direction.Normalize();
    //     movement = direction;

    // }

    // void moveCharacter(Vector2 direction)
    // {
    //     rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    // }

    private void setEnemyValues()
    {
        GetComponent<health>().setHealth(data.maxHp + (playerDMG * playerLvl), data.maxHp + (playerDMG * playerLvl));
        damage = data.damage + (playerLvl * 2);
        speed = data.speed;
        atkSpeed = data.atkSpeed;
        object1Transform = data.object1Transform;
        object2Transform = data.object2Transform;
        this.GetComponent<AIPath>().maxSpeed = speed;
        this.GetComponent<health>().weaponNum = dropWep;
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
            collider.GetComponent<health>().damageSound();
            Debug.Log("ATTACKED BAM");
            yield return new WaitForSeconds(atkSpeed);
        }
    }

    public void scaleEnemy()
    {
        damage = damage + (playerLvl * 5f);
    }


}
