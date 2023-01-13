using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideAfter : MonoBehaviour
{
    float timer;
    float hideTime;

    private void OnEnable()
    {
        timer = hideTime;

    }

    private void LateUpdate()
    {
        timer -= Time.deltaTime;
        if(timer < 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
