using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThisCard : MonoBehaviour
{
    public DeckScript deckScript;
    public TurnManager turnManager;
    public GameObject player1Body;

    public int thisId;

    public int id;
    public string name;
    public int type;
    public int color;
    public int cardAmount;

    public Text cardText;
    public Image cardArt;
    public Sprite cardArtSprite;
    public GameObject cardBack;
    public  bool  isCardBack;

    public GameObject hand;
    public GameObject canvas;

    public bool canBeSummoned;
    public bool isSummoned;
    // Start is called before the first frame update
    void Start()
    {
        deckScript = GameObject.FindGameObjectWithTag("Deck").GetComponent<DeckScript>();
        turnManager = GameObject.FindGameObjectWithTag("TurnManager").GetComponent<TurnManager>();
        player1Body = GameObject.Find("Player 1 Body");
        thisId = deckScript.DrawCard().id;
        name = CardDatabase.cardList[thisId].name;
        gameObject.name = name;
    }

    // Update is called once per frame
    void Update()
    {
        hand = GameObject.Find("Hand");
        canvas = GameObject.Find("Canvas");
        if (gameObject.transform.parent == (hand.transform.parent || canvas))
        {
            isCardBack = false;
        }
        id = CardDatabase.cardList[thisId].id;
        name = CardDatabase.cardList[thisId].name;
        type = CardDatabase.cardList[thisId].type;
        color = CardDatabase.cardList[thisId].color;
        cardAmount = CardDatabase.cardList[thisId].cardAmount;

        cardText.text = name;
        cardArtSprite = CardDatabase.cardList[thisId].cardArt;
        cardArt.sprite = cardArtSprite;
        if (isCardBack)
        {
            cardBack.SetActive(true);
        }
        else
        {
            cardBack.SetActive(false);
        }

        if (turnManager.isPlayer1Turn && isSummoned == false)
        {
            canBeSummoned = true;
        }
        else
        {
            canBeSummoned = false;
        }

        if (canBeSummoned == true)
        {
            gameObject.GetComponent<Draggable>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Draggable>().enabled = false;
        }

        if (isSummoned == false && transform.parent.parent == player1Body.transform)
        {
            isSummoned = true;
            turnManager.EndTurn();
        }
    }
}
