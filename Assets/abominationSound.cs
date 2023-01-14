using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abominationSound : MonoBehaviour
{   
    public AudioSource roarPlayer;
    public AudioClip roarAbomination;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("roarSound", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void roarSound()
    {
        roarPlayer.PlayOneShot(roarAbomination);
    }
}
