using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
     public GameObject cardPrefab;
    void Start()
    {
        foreach (Card card in CardDatabase.cardList)
        {
            // Add the card to the deck according to its amount
            for (int i = 0; i < card.cardAmount; i++)
            {
                deck.Add(card);
            }
        }
    }
    public Card DrawCard()
    {
        int randomIndex = Random.Range(0, deck.Count);
        Card randomCard = deck[randomIndex];
        deck.RemoveAt(randomIndex);
        return randomCard;
    }
    public void Shuffle(List<Card> cardsToAdd)
    {
        deck.AddRange(cardsToAdd); 
        for (int i = 0; i < deck.Count; i++)
        {
            Card temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
