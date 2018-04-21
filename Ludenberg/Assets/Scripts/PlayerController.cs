using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // MUST BE PUBLIC or else Unity cannot access variable.
    public float _speed = 3.0f;

    private Animator _anim;
    private bool _playerMoving;
    private Vector2 _lastMove;

    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        _playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") >= 0.5f || Input.GetAxisRaw("Horizontal") <= -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime, 0.0f, 0.0f));
            _playerMoving = true;
            _lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0.0f);
        }

        if (Input.GetAxisRaw("Vertical") >= 0.5f || Input.GetAxisRaw("Vertical") <= -0.5f)
        {
            transform.Translate(new Vector3(0.0f, Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime, 0.0f));
            _playerMoving = true;
            _lastMove = new Vector2(0.0f, Input.GetAxisRaw("Vertical"));
        }

        // Set animator parameters
        _anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        _anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        _anim.SetBool("PlayerMoving", _playerMoving);
        _anim.SetFloat("LastMoveX", _lastMove.x);
        _anim.SetFloat("LastMoveY", _lastMove.y);
    }
}
