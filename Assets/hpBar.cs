using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpBar : MonoBehaviour
{
    public GameObject bar;

    public void SetSize(float sizeNormalized)
    {
        bar.transform.localScale = new Vector3(sizeNormalized, 1f, 1f);
    }

}
