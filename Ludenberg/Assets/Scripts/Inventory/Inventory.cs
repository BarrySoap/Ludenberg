using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static List<Card> cardCollection = new List<Card>();
    public static CardDatabase cd;

    public void Start()
    {
        cd = FindObjectOfType<CardDatabase>();
        Inventory.GiveCard("Fire Card");
        Inventory.GiveCard("Water Card");
        Inventory.GiveCard("Earth Card");
        Inventory.GiveCard("Wind Card");
        Inventory.GiveCard("Light Card");
        Inventory.GiveCard("Dark Card");
        Inventory.GiveCard("Chrono Card");
        Inventory.GiveCard("Electric Card");
    }

    public static void GiveCard(int id)
    {
        Card cardToAdd = cd.GetCard(id);
        cardCollection.Add(cardToAdd);
        Debug.Log("Added card: " + cardToAdd.cardName);
    }

    public static void GiveCard(string cardName)
    {
        Card cardToAdd = cd.GetCard(cardName);
        cardCollection.Add(cardToAdd);
        Debug.Log("Added card: " + cardToAdd.cardName);
    }

    public static Card CheckForCard(int id)
    {
        return cardCollection.Find(card => card.id == id);
    }

    public static void RemoveCard(int id)
    {
        Card card = CheckForCard(id);
        if (card != null)
        {
            cardCollection.Remove(card);
            Debug.Log("Item removed: " + card.cardName);
        }
    }

    public static int GetCollectionSize()
    {
        return cardCollection.Count;
    }
}
