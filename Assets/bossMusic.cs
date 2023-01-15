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
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float startVolume = 0f;
        bossPlayer.PlayOneShot(bossBG);
        bossPlayer.volume = startVolume;

        while (bossPlayer.volume < 0.3)
        {
            bossPlayer.volume += Time.deltaTime / fadeTime;
            yield return null;
        }
    }
}
