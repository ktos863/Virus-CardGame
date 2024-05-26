using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, 0, Resources.Load<Sprite>("1")));

        cardList.Add(new Card(1, "Brain", 1, 1, 5, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(2, "Heart", 1, 2, 5, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(3, "Stomach", 1, 3, 5, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(4, "Bone", 1, 4, 5, Resources.Load<Sprite> ("1")));
        cardList.Add(new Card(5, "Joker-Organ", 1, 5, 1, Resources.Load<Sprite>("1")));

        cardList.Add(new Card(6, "Brain Virus", 2, 1, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(7, "Heart Virus", 2, 2,  4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(8, "Stomach Virus", 2, 3, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(9, "Bone Virus", 2, 4, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(10, "SuperVirus", 2, 5, 1, Resources.Load<Sprite>("1")));

        cardList.Add(new Card(11, "Brain Cure", 3, 1, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(12, "Heart Cure", 3, 2, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(13, "Stomach Cure", 3, 3, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(14, "Bone Cure", 3, 4, 4, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(15, "Panaceum", 3, 5, 4, Resources.Load<Sprite>("1")));

        cardList.Add(new Card(16, "Transplant", 4, 6, 3, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(17, "Organ Thief", 4, 6, 3, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(18, "Sneeze", 4, 6, 2, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(19, "Card Replace", 4, 6, 1, Resources.Load<Sprite>("1")));
        cardList.Add(new Card(20, "Organism Exchange", 4, 6, 1, Resources.Load<Sprite>("1")));
    }
}