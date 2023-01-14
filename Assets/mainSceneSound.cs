using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainSceneSound : MonoBehaviour
{
    public AudioSource bgSource;
    public AudioSource nonLoop;
    public AudioClip bgSound;
    public AudioClip lvlUpSound;

    void Start()
    {
        Invoke("playBG", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
