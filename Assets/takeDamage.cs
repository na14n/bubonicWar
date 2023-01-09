using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    
    public Color damageColor;
    private Color originalColor;
    private bool damaged = false;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = this.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged) {
        this.GetComponent<SpriteRenderer>().color = damageColor;
        damaged = false;
        Invoke("ResetColor", 0.2f);
    }
    }

    public void TakeDamage() {
    damaged = true;
    }

    void ResetColor() {
    this.GetComponent<SpriteRenderer>().color = originalColor;
    }
}
