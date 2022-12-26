using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
        public int totalWeapons = 1;
        public int weaponIndex = 2;
        
        public GameObject[] weapons;
        public GameObject weaponHolder;
        public GameObject currentWep;
    
    // Start is called before the first frame update
    void Start()
    {
        totalWeapons = weaponHolder.transform.childCount;
        weapons = new GameObject[totalWeapons];

        for (int i = 0; i < totalWeapons; i++)
        {
            weapons[i] = weaponHolder.transform.GetChild(i).gameObject;
            weapons[i].SetActive(false);
        }

        weapons[0].SetActive(true);
        currentWep = weapons[0];
        weaponIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
        
        if(weaponIndex < totalWeapons-1)
        {
            weapons[weaponIndex].SetActive(false);
            weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;
            weaponIndex += 1;
            weapons[weaponIndex].SetActive(true);
            weapons[weaponIndex].GetComponent<Collider2D>().enabled = true;

        }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
        
        if(weaponIndex > 0)
        {
            weapons[weaponIndex].SetActive(false);
            weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;
            weaponIndex -= 1;
            weapons[weaponIndex].SetActive(true);
            weapons[weaponIndex].GetComponent<Collider2D>().enabled = true;

        }
        }
    }
}
