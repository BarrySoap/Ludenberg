using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    [SerializeField]
    Image highlighter;
    [SerializeField]
    Sprite cardBorder;
    [SerializeField]
    Image selectedCard;

    int cardAccumulator = 0;
    Text[] options;
    Image[] cardSlots;
    List<Card> battleCards;
    bool onActions = true;
    string optionHighlighted = "";

    void Start()
    {
        battleCards = new List<Card>();
        Inventory.ShuffleCards();

        options = gameObject.GetComponentsInChildren<Text>();
        cardSlots = gameObject.GetComponentsInChildren<Image>();
        
        for (int i = 0; i < cardSlots.Length; i++)
        {
            if (!cardSlots[i].name.Contains("Card Slot"))
            {
                cardSlots[i] = cardSlots[cardSlots.Length - 1];
                System.Array.Resize(ref cardSlots, cardSlots.Length - 1);
            }
        }
        System.Array.Sort(cardSlots, (x, y) => string.Compare(x.name, y.name));
        
        for (int i = 0; i < 8; i++)
        {
            battleCards.Add(Inventory.cardCollection[i]);
            cardSlots[i].sprite = battleCards[i].icon;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (highlighter.rectTransform.anchoredPosition.y == 40.0f)
            {
                highlighter.rectTransform.anchoredPosition = new Vector3(-16.0f, -20.0f, 0.0f);
                optionHighlighted = "Debug";
            }
            else if (highlighter.rectTransform.anchoredPosition.y == -20.0f)
            {
                highlighter.rectTransform.anchoredPosition = new Vector3(-16.0f, 40.0f, 0.0f);
                optionHighlighted = "Attack";
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (onActions == false)
            {
                Card tempCard = battleCards[cardAccumulator];
            }

            if (optionHighlighted == "Attack")
            {
                onActions = false;
                highlighter.enabled = false;
                selectedCard.rectTransform.position = cardSlots[cardAccumulator].rectTransform.position;
            }
            else
            {
                Debug.Log("Debug");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onActions = true;
            highlighter.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && onActions == false)
        {
            if (cardAccumulator != cardSlots.Length - 1)
            {
                cardAccumulator++;
                selectedCard.rectTransform.position = cardSlots[cardAccumulator].rectTransform.position;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && onActions == false)
        {
            if (cardAccumulator != 0)
            {
                cardAccumulator--;
                selectedCard.rectTransform.position = cardSlots[cardAccumulator].rectTransform.position;
            }
        }
    }
}
