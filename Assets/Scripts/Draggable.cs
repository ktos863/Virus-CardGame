using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.Netcode;

public class Draggable : NetworkBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturn;
    public ThisCard card;
    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        parentToReturn = transform.parent;
        transform.SetParent(transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        DropZone[] zones = GameObject.FindObjectsOfType<DropZone>();
    }

    public void OnDrag(PointerEventData pointerEventData)
    {
        this.transform.position = pointerEventData.position;
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
        transform.SetParent(parentToReturn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
