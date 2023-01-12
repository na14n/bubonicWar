using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
