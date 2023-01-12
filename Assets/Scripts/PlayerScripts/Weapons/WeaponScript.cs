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
// weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;

weapons[newIndex].SetActive(true);
// weapons[newIndex].GetComponent<Collider2D>().enabled = true;
weaponIndex = newIndex;
currentWep = weapons[weaponIndex];
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
// weapons[weaponIndex].GetComponent<Collider2D>().enabled = false;

weapons[newIndex].SetActive(true);
// weapons[newIndex].GetComponent<Collider2D>().enabled = true;
weaponIndex = newIndex;
currentWep = weapons[weaponIndex];
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

public void AddNewWeapon(GameObject newWeaponPrefab)
{
    // Instantiate the new weapon prefab
    GameObject newWeapon = Instantiate(newWeaponPrefab, weaponHolder.transform);

    // Add the new weapon to the weapons array and update the totalWeapons variable
    totalWeapons++;
    GameObject[] newWeapons = new GameObject[totalWeapons];
    for (int i = 0; i < totalWeapons - 1; i++)
    {
        newWeapons[i] = weapons[i];
    }
    newWeapons[totalWeapons - 1] = newWeapon;
    weapons = newWeapons;

    // Set the new weapon to be the active weapon
    newWeapon.SetActive(true);
    // newWeapon.GetComponent<Collider2D>().enabled = true;

    // Deactivate the current weapon and disable its collider
    currentWep.SetActive(false);
    // currentWep.GetComponent<Collider2D>().enabled = false;

    // Update the weaponIndex and currentWep variables
    weaponIndex = totalWeapons - 1;
    currentWep = newWeapon;
}
}
