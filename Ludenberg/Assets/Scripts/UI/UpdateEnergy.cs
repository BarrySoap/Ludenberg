using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEnergy : MonoBehaviour
{
    Player player;
    Enemy enemy;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
    }

    void Update()
    {
        if (gameObject.name.Contains("Player"))
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = 
                new Vector2((player.Energy / player.MaxEnergy) * 100.0f, 20.0f);
        }
        else if (gameObject.name.Contains("Enemy"))
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = 
                new Vector2((player.Energy / player.MaxEnergy) * 100.0f, 20.0f);
        }
    }
}