using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class floatingDamage : MonoBehaviour
{
     public float speed = 1f;
    public float lifetime = 1f;
    public float damage;

    void Start()
    {
        Destroy(transform.parent.gameObject, lifetime);
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
