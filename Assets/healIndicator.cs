using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        //15F800
        TMPro.TextMeshPro text = GetComponent<TextMeshPro>();
        text.color = new Color (0f,0.9f,0.2f,1f);

    }
}
