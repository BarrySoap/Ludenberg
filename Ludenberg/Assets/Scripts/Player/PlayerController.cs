using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float _speed;

    private float horizontal;
    private float vertical;
    private float diagonal = 0.7f;
    private Rigidbody2D _playerBody;

    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= diagonal;
            vertical *= diagonal;
        }

        _playerBody.velocity = new Vector2(horizontal * _speed, vertical * _speed);
    }
}
