using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public bool isPlayer1Turn;
    public Text turnText;
    public HandScript hand;
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            isPlayer1Turn = true;
            turnText.text = "Player 1 Turn";
        }
        else
        {
            isPlayer1Turn = false;
            turnText.text = "Player 2 Turn";
        }
    }
    public void EndTurn()
    {
        if (isPlayer1Turn)
        {
            isPlayer1Turn = false;
            turnText.text = "Player 2 Turn";
            while (hand.transform.childCount < 3)
            {
                hand.DrawCardToHand();
            }
        }
        else
        {
            isPlayer1Turn = true;
            turnText.text = "Player 1 Turn";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
