using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Object;
    public Animator animatorComponent;

    void Start()
    {   
        animatorComponent = Object.GetComponent<Animator>();  
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animatorComponent.SetBool("hover", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animatorComponent.SetBool("hover", false);
    }
}
