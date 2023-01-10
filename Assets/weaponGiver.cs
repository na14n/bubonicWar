using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponGiver : MonoBehaviour
{
    public GameObject wep1;
    public GameObject wep2;
    public GameObject wep3;
    public GameObject wep4;
    public GameObject wep5;
    public GameObject wep6;
    public GameObject wep7;
    public GameObject wep8;
    public GameObject wepHandler;

    public int wepOneChoice;
    public int wepTwoChoice;
    // Start is called before the first frame update

    void Start()
    {
        wepOneChoice = variablePasser.Instance.firstWep;
        wepTwoChoice = variablePasser.Instance.secondWep;
        WeaponChooserOne();
        // WeaponChooserTwo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void WeaponChooserOne()
    {
        WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();

        if (wepOneChoice == 1)
        {
            weaponScript.AddNewWeapon(wep1);
        }

        else if (wepOneChoice == 2)
        {
            weaponScript.AddNewWeapon(wep2);
        }

        else if (wepOneChoice == 3)
        {
            weaponScript.AddNewWeapon(wep3);
        }

        else if (wepOneChoice == 4)
        {
            weaponScript.AddNewWeapon(wep4);
        }

        else if (wepOneChoice == 5)
        {
            weaponScript.AddNewWeapon(wep5);
        }

        else if (wepOneChoice == 6)
        {
            weaponScript.AddNewWeapon(wep6);
        }
        else if (wepOneChoice == 7)
        {
            weaponScript.AddNewWeapon(wep7);
        }
        else if (wepOneChoice == 8)
        {
            weaponScript.AddNewWeapon(wep8);
        }
    }

    // void WeaponChooserTwo()
    // {
    //     WeaponScript weaponScript = wepHandler.GetComponent<WeaponScript>();
    //     if (wepTwoChoice == 1)
    //     {
    //         weaponScript.AddNewWeapon(wep1);
    //     }

    //     else if (wepTwoChoice == 2)
    //     {
    //         weaponScript.AddNewWeapon(wep2);
    //     }

    //     else if (wepTwoChoice == 3)
    //     {
    //         weaponScript.AddNewWeapon(wep3);
    //     }

    //     else if (wepTwoChoice == 4)
    //     {
    //         weaponScript.AddNewWeapon(wep4);
    //     }

    //     else if (wepTwoChoice == 5)
    //     {
    //         weaponScript.AddNewWeapon(wep5);
    //     }

    //     else if (wepTwoChoice == 6)
    //     {
    //         weaponScript.AddNewWeapon(wep6);
    //     }

    // }
}
