using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainSceneSound : MonoBehaviour
{
    public AudioSource bgSource;
    public AudioSource nonLoop;
    public AudioClip bgSound;
    public AudioClip lvlUpSound;
    public GameObject audioSRC;

    void Start()
    {   
        PlayerPrefs.SetInt("Abomination", 0);
        Invoke("playBG", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Abomination") == 1)
        {
            audioSRC.SetActive(false);
            PlayerPrefs.SetInt("Abomination", 0);
        }
    }

        public void playBG()
    {
            bgSource.PlayOneShot(bgSound);
    }

        public void lvlUp()
    {
            nonLoop.PlayOneShot(lvlUpSound);
    }
}
