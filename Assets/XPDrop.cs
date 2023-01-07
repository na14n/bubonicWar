using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPDrop : MonoBehaviour
{

    public int xpAmount = 10; // The amount of XP to drop
    public GameObject xpPrefab;
    public int mobHP;
    
    void Update()
    {
        mobHP = transform.parent.GetComponent<health>().hp;
        // Check if the mob has died and drop the XP if it has
        if (mobHP <=0 )
        {
            // Instantiate the XP drop at the same position as the mob
            GameObject xp = Instantiate(xpPrefab, transform.position, Quaternion.identity);
            // Set the XP drop's amount of XP
            xp.GetComponent<XPDrop>().xpAmount = xpAmount;

            Destroy(transform.parent.gameObject);
        }
    }
}
