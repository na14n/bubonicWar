using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class guardianScript : MonoBehaviour
{
    [SerializeField]
    public float damage = 5;
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
    public playerStats playerStatx;
    public float playerLvl;
    public int dropWep;


    // Start is called before the first frame update

    void Awake()
    {
        playerStatx = FindObjectOfType<playerStats>();
        playerLvl = playerStatx.playerLvl;
    }
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        hp = maxHp;
        setEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {   
    }

    private void setEnemyValues()
    {
        GetComponent<health>().setHealth(data.maxHp + (playerLvl * 3), data.maxHp + (playerLvl * 3));
        object1Transform = data.object1Transform;
        object2Transform = data.object2Transform;
        this.GetComponent<health>().weaponNum = dropWep;
    }

}
