using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressed;
    public GameObject helpImage;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
       
            helpImage.SetActive(true);
            
       

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        helpImage.SetActive(false);
    }
}