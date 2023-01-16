using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xpBar : MonoBehaviour
{

    public Slider xpSlider;

    public void SetXp(float xpSizeNormalized)
    {
        xpSlider.value = xpSizeNormalized;
    }
}
