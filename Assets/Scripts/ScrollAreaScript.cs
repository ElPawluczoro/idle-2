using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollAreaScript : ScrollRect
{
    public override void OnBeginDrag(PointerEventData eventData)
    {
        //base.OnBeginDrag(eventData);
        eventData.Use();
    }
    public override void OnDrag(PointerEventData eventData)
    {
        //base.OnDrag(eventData);
        eventData.Use();
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        //base.OnEndDrag(eventData);
        eventData.Use();
    }

}
