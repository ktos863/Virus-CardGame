using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public ThisCard cardBeingPlayed;
    public ThisCard card;
    public void OnDrop(PointerEventData pointerEventData)
    {
        cardBeingPlayed = pointerEventData.pointerDrag.GetComponent<ThisCard>();
        if (transform.childCount > 0)
        {
            card = transform.GetChild(0).GetComponent<ThisCard>();
        }
        if (cardBeingPlayed.type == 1 && transform.childCount == 0)
        {
            DropCard(pointerEventData);
        }
        else if ((card.color == cardBeingPlayed.color || card.color == 5 || cardBeingPlayed.color == 5) && cardBeingPlayed.type != 1)
        {
            DropCard(pointerEventData);
        }
    }
    public void DropCard(PointerEventData pointerEventData)
    {
        Draggable draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        draggable.parentToReturn = this.transform;
    }
}
