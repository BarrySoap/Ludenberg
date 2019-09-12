using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Elements
{
    Fire = 1,
    Water = 1 << 1,
    Earth = 1 << 2,
    Wind = 1 << 3,
    Light = 1 << 4,
    Dark = 1 << 5,
    Chrono = 1 << 6,
    Electric = 1 << 7,
    Ice = Water | Wind,
    Steam = Fire | Water,
    Lava = Fire | Earth,
    Smoke = Fire | Wind,
    Energy = Chrono | Electric
}

public class Card : MonoBehaviour
{
    static Sprite[] icons = Resources.LoadAll<Sprite>("Cards/");
    
    private int tier;
    private int cost;
    public int id;
    public string cardName;
    private string description;
    private Elements element;
    public Sprite icon;

    public Card(int id, string cardName, string description, int tier, int cost)
    {
        this.id = id;
        this.cardName = cardName;
        this.description = description;
        this.tier = tier;
        this.cost = cost;
        Enum.TryParse((1 << UnityEngine.Random.Range(1, 8)).ToString(), out this.element);

        for (int i = 0; i < icons.Length; i++)
        {
            if (cardName.Contains(icons[i].name))
            {
                icon = icons[i];
            }
        }
    }

    public int Tier
    {
        get { return tier; }
        set { tier = value; }
    }
    
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    void Start()
    {
        //Enum.TryParse((1 << UnityEngine.Random.Range(1, 8)).ToString(), out Elements element);
    }
}
