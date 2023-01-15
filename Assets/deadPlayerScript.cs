using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadPlayerScript : MonoBehaviour
{
    void Start()
    {
        Invoke("dead", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dead()
    {
        Destroy(gameObject);
    }
}
