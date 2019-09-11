using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    private List<Card> cardList;

    private void Awake()
    {
        BuildDatabase();
    }

    public Card GetCard(int id)
    {
        return cardList.Find(card => card.id == id);
    }

    public Card GetCard(string cardName)
    {
        return cardList.Find(card => card.cardName == cardName);
    }

    void BuildDatabase()
    {
        cardList = new List<Card>
        {
            // Tier 1
            new Card(0, "Fire Card", "A basic card filled with Fire Elementia", 1, 20),
            new Card(1, "Water Card", "A basic card filled with Water Elementia", 1, 20),
            new Card(2, "Earth Card", "A basic card filled with Earth Elementia", 1, 20),
            new Card(3, "Wind Card", "A basic card filled with Wind Elementia", 1, 20),
            new Card(4, "Light Card", "A basic card filled with Light Elementia", 1, 20),
            new Card(5, "Dark Card", "A basic card filled with Dark Elementia", 1, 20),
            new Card(6, "Chrono Card", "A basic card filled with Chrono Elementia", 1, 20),
            new Card(7, "Electric Card", "A basic card filled with Electric Elementia", 1, 20),
            new Card(8, "Ice Card", "A basic card filled with Ice Elementia", 1, 40),
            new Card(9, "Steam Card", "A basic card filled with Steam Elementia", 1, 40),
            new Card(10, "Lava Card", "A basic card filled with Lava Elementia", 1, 40),
            new Card(11, "Smoke Card", "A basic card filled with Smoke Elementia", 1, 40),
            new Card(12, "Energy Card", "A basic card filled with Energy Elementia", 1, 40),

            // Tier 2
            new Card(0, "Fire Card", "A basic card filled with Fire Elementia", 2, 20),
            new Card(1, "Water Card", "A basic card filled with Water Elementia", 2, 20),
            new Card(2, "Earth Card", "A basic card filled with Earth Elementia", 2, 20),
            new Card(3, "Wind Card", "A basic card filled with Wind Elementia", 2, 20),
            new Card(4, "Light Card", "A basic card filled with Light Elementia", 2, 20),
            new Card(5, "Dark Card", "A basic card filled with Dark Elementia", 2, 20),
            new Card(6, "Chrono Card", "A basic card filled with Chrono Elementia", 2, 20),
            new Card(7, "Electric Card", "A basic card filled with Electric Elementia", 2, 20),
            new Card(8, "Ice Card", "A basic card filled with Ice Elementia", 2, 40),
            new Card(9, "Steam Card", "A basic card filled with Steam Elementia", 2, 40),
            new Card(10, "Lava Card", "A basic card filled with Lava Elementia", 2, 40),
            new Card(11, "Smoke Card", "A basic card filled with Smoke Elementia", 2, 40),
            new Card(12, "Energy Card", "A basic card filled with Energy Elementia", 2, 40),

            // Tier 3
            new Card(0, "Fire Card", "A basic card filled with Fire Elementia", 3, 20),
            new Card(1, "Water Card", "A basic card filled with Water Elementia", 3, 20),
            new Card(2, "Earth Card", "A basic card filled with Earth Elementia", 3, 20),
            new Card(3, "Wind Card", "A basic card filled with Wind Elementia", 3, 20),
            new Card(4, "Light Card", "A basic card filled with Light Elementia", 3, 20),
            new Card(5, "Dark Card", "A basic card filled with Dark Elementia", 3, 20),
            new Card(6, "Chrono Card", "A basic card filled with Chrono Elementia", 3, 20),
            new Card(7, "Electric Card", "A basic card filled with Electric Elementia", 3, 20),
            new Card(8, "Ice Card", "A basic card filled with Ice Elementia", 3, 40),
            new Card(9, "Steam Card", "A basic card filled with Steam Elementia", 3, 40),
            new Card(10, "Lava Card", "A basic card filled with Lava Elementia", 3, 40),
            new Card(11, "Smoke Card", "A basic card filled with Smoke Elementia", 3, 40),
            new Card(12, "Energy Card", "A basic card filled with Energy Elementia", 3, 40),
        };
    }
}
