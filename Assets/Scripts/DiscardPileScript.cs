using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscardPileScript : MonoBehaviour, IDropHandler
{
    public List<Card> discardPile = new List<Card>();
    public DeckScript deck;

    public int discardedId;
    public void Start()
    {
        discardPile.Clear();
    }
    public void OnDrop(PointerEventData pointerEventData)
    {
        Draggable draggable = pointerEventData.pointerDrag.GetComponent<Draggable>();
        draggable.parentToReturn = this.transform;
        ThisCard discardedCard = pointerEventData.pointerDrag.GetComponent<ThisCard>();
        discardedId = discardedCard.thisId;
        Card card = CardDatabase.cardList[discardedId];
        discardPile.Add(card);
        Destroy(pointerEventData.pointerDrag);
    }

    void Update()
    {
        if(deck.deck.Count < 3)
        {
            deck.Shuffle(discardPile);
            discardPile.Clear();
        }
    }
}
