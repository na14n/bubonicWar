using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "ScriptableOBjects/Enemy", order = 1)]
public class EnemyData : ScriptableObject
{
    public int hp;
    public float damage;
    public int speed;
    public float maxHp;
    public float atkSpeed;
    public Vector3 object1Transform;
    public Vector3 object2Transform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
