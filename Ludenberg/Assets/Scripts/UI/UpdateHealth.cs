using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealth : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.name.Contains("Player"))
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = 
                new Vector2(GameObject.Find("Player").GetComponent<Player>().Health, 20.0f);
        }
        else if (gameObject.name.Contains("Enemy"))
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = 
                new Vector2(GameObject.Find("Enemy").GetComponent<Enemy>().Health, 20.0f);
        }
    }
}
