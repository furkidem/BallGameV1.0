using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class dokunma : MonoBehaviour, IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    Image joyarka;
    Image joys;
    Vector3 giriliv;
    public GameObject daire;
    void Start()
    {
        joyarka = gameObject.transform.GetComponent<Image>();
        joys = gameObject.transform.GetChild(0).GetComponent<Image>();
    }

    public void OnDrag(PointerEventData ped)
    {
        Vector2 pozisyon;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(joyarka.rectTransform,ped.position, ped.enterEventCamera, out pozisyon))
        {
            pozisyon.x = (pozisyon.x / joyarka.rectTransform.sizeDelta.x);
            pozisyon.y = (pozisyon.y/ joyarka.rectTransform.sizeDelta.y);
           
            giriliv = new Vector3(pozisyon.x * 2, 0, pozisyon.y * 2);
            giriliv = (giriliv.magnitude > 1.0f) ? giriliv.normalized : giriliv;
            joys.rectTransform.anchoredPosition = new Vector3(giriliv.x * joys.rectTransform.sizeDelta.x/(1.5f), 0,giriliv.z * joys.rectTransform.sizeDelta.y/1.5f);
        }
    }

    public void OnPointerUp(PointerEventData ped)
    {
        giriliv = Vector3.zero;
        joys.rectTransform.anchoredPosition = Vector3.zero;
    }

    public void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    void Update()
    {
        daire.transform.position += giriliv * Time.deltaTime * 70;
    }
}
