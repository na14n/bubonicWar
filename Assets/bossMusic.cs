using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMusic : MonoBehaviour
{   
    public AudioSource bossPlayer;
    public AudioClip bossBG;
    // Start is called before the first frame update
    void Start()
    {
        bossPlayer.PlayOneShot(bossBG);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
