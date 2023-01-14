using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSourceAttack : MonoBehaviour
{
    public AudioSource attackSource;
    public AudioClip attackSound;
    public AudioClip attackSound2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playAttack()
    {
        int x = Random.Range(1, 100);
        if (x <= 50)
        {
            attackSource.PlayOneShot(attackSound);
        }

        else
        {
            attackSource.PlayOneShot(attackSound2);
        }

    }
}

