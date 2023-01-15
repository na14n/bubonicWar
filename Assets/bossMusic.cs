using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMusic : MonoBehaviour
{   
    public AudioSource bossPlayer;
    public AudioClip bossBG;
    public float fadeTime = 10f;

    private void Start()
    {
        Invoke("playBG", 2f);
    }

    public void playBG()
    {
        bossPlayer.enabled = true;
        bossPlayer.Play();
    }

}
