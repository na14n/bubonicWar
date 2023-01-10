using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPicker : MonoBehaviour
{
    public int wepNum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {   
            if (wepNum == 1)
            {   
                Debug.Log("katana unloced");
                PlayerPrefs.SetInt("Katana", 1);
            }

            if (wepNum == 2)
            {   
                Debug.Log("katana unloced");
                
                PlayerPrefs.SetInt("Scythe", 1);
            }
            
            Destroy(gameObject);
        }
    }
}

