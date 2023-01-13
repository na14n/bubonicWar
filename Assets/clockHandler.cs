using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clockHandler : MonoBehaviour
{   
    public float startTime;
    public TextMeshProUGUI text1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startTimer", 5f);
    }

    // Update is called once per frame
    void Update()
    {   
        StartCoroutine(timerLogic());
    }

    void startTimer()
    {
        startTime = Time.time;
    }
    
    IEnumerator timerLogic()
    {

        yield return new WaitForSeconds(5f);

        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        text1.text = minutes + ":" + seconds;
    }
}
