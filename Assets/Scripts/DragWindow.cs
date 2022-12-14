using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour, IDragHandler, IPointerDownHandler
{

    [SerializeField]
    private RectTransform dragRrectTransform;

    [SerializeField]
    private Canvas canvas;

    public void closeWindow()
    {
        Destroy(dragRrectTransform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragRrectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragRrectTransform.SetAsLastSibling();
    }
}
