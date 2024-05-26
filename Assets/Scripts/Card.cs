using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : ScriptableObject
{
    public int id;
    public string name;
    public int type;
    public int color;
    public int cardAmount;

    public Sprite cardArt;

    public Card()
    {

    }

    public Card(int Id, string Name, int Type, int Color, int CardAmount, Sprite CardArt)
    {
        id = Id;
        name = Name;
        type = Type;
        color = Color;
        cardAmount = CardAmount;
        cardArt = CardArt;
    }
}
