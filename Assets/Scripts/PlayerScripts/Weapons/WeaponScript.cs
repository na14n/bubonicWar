using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
        public int totalWeapons = 1;
        public int weaponIndex;
        
        public GameObject[] weapons;
        public GameObject weaponHolder;
        public GameObject currentWep;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateWeaponsArray();
    }

    // Update is called once per frame
    void Update()
{
if(Input.GetKeyDown(KeyCode.E))
{
    if (weaponIndex < 0 || weaponIndex >= totalWeapons)
    {
        return;
    }
    if(weaponIndex < totalWeapons-1)
    {
        int newIndex = weaponIndex + 1;
        if (newIndex < 0 || newIndex >= totalWeapons)
        {
            return;
        }
        weapons[weaponIndex].SetActive(false);
        weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;

        weapons[newIndex].SetActive(true);
        weapons[newIndex].GetComponent<Collider2D>().enabled = true;
        weaponIndex = newIndex;
    }
}

if(Input.GetKeyDown(KeyCode.Q))
{
    if (weaponIndex < 0 || weaponIndex >= totalWeapons)
    {
        return;
    }
    if(weaponIndex > 0)
    {
        int newIndex = weaponIndex - 1;
        if (newIndex < 0 || newIndex >= totalWeapons)
        {
            return;
        }
        weapons[weaponIndex].SetActive(false);
        weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;

        weapons[newIndex].SetActive(true);
        weapons[newIndex].GetComponent<Collider2D>().enabled = true;
        weaponIndex = newIndex;
    }
}
}

public void UpdateWeaponsArray()
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
}
