using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject card;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            DrawCardToHand();
        }
    }
    public void DrawCardToHand()
    {
        GameObject newCard = Instantiate(card, hand.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
