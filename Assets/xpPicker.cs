using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpPicker : MonoBehaviour
{   
    int xpReceive;
    void Start()
    {

    }
    void OnTriggerEnter(Collider collider)
    {   
        xpReceive = collider.GetComponent<health>().xpAmount;

        if (collider.gameObject.CompareTag("XP"))
        {   
            GetComponent<playerStats>().increaseXP(xpReceive);
            Destroy(collider.gameObject);
            Debug.Log("target hit");
        }
    }
}
