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
    Sprite selectedCard;

    int cardAccumulator = 0;
    Text[] options;
    Image[] cards;
    bool onActions = true;
    string optionHighlighted = "";

    void Start()
    {
        options = gameObject.GetComponentsInChildren<Text>();
        cards = gameObject.GetComponentsInChildren<Image>();
        
        for (int i = 0; i < cards.Length; i++)
        {
            if (!cards[i].name.Contains("Card Slot"))
            {
                cards[i] = cards[cards.Length - 1];
                System.Array.Resize(ref cards, cards.Length - 1);
            }
        }
        System.Array.Sort(cards, (x, y) => string.Compare(x.name, y.name));
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
            if (optionHighlighted == "Attack")
            {
                onActions = false;
                highlighter.enabled = false;
                cards[cardAccumulator].sprite = selectedCard;
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
            if (cardAccumulator != cards.Length - 1)
            {
                cards[cardAccumulator].sprite = cardBorder;
                cardAccumulator++;
                cards[cardAccumulator].sprite = selectedCard;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && onActions == false)
        {
            if (cardAccumulator != 0)
            {
                cards[cardAccumulator].sprite = cardBorder;
                cardAccumulator--;
                cards[cardAccumulator].sprite = selectedCard;
            }
        }
    }
}
