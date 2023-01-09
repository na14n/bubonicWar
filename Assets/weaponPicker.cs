using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPicker : MonoBehaviour
{
    public GameObject anotherLegWep;
    public GameObject toAddWep;
    public GameObject wepHandler;
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
            WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
            weaponScript.AddNewWeapon(toAddWep);
            Destroy(anotherLegWep);
            Destroy(gameObject);
        }
    }
}

