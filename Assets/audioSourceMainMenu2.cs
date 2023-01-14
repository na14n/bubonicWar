using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSourceMainMenu2 : MonoBehaviour
{
    public AudioSource player1;
    public AudioSource nonLoop;
    public AudioClip bg1;
    public AudioClip buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("playBG", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playBG()
    {
        player1.PlayOneShot(bg1);
    }

    public void playButton()
    {
        nonLoop.PlayOneShot(buttonClick);
    }
}
