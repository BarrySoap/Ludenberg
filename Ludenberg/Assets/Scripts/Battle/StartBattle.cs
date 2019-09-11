using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(collision.gameObject);
        SceneManager.LoadScene(1);
        gameObject.transform.position = new Vector3(-6.5f, 1.0f, 0.0f);
        collision.gameObject.transform.position = new Vector3(6.5f, 1.0f, 0.0f);
        gameObject.GetComponent<PlayerController>()._speed = 0;
    }
}
