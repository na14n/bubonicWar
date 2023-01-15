using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageAndHealSound : MonoBehaviour
{
    public AudioSource audSRC;
    public AudioClip heal;
    public AudioClip damage;
    public AudioClip damage1;
    public AudioClip xp;
    public AudioClip item;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void xpSound()
    {
        audSRC.PlayOneShot(heal);
    }

    public void itemSound()
    {
        audSRC.PlayOneShot(item);
    }


    public void healSound()
    {
        audSRC.PlayOneShot(xp);
    }

    public void damageSound()
    {
        int x = Random.Range(1, 100);

        if (x < 50)
        {
            audSRC.PlayOneShot(damage);
        }

        else
        {
            audSRC.PlayOneShot(damage1);
        }

    }
}
