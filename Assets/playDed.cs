using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playDed : MonoBehaviour
{
    public AudioClip dedo;
    public AudioSource nonLoop;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ded()
    {
        nonLoop.PlayOneShot(dedo);
    }
}
