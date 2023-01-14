using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class healIndicator : MonoBehaviour
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
        this.GetComponent<TextMeshPro>().color = new Color(0,255,0);
    }
}