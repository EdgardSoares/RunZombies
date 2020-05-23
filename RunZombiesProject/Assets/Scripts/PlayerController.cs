using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float _speed;
    public float _jumpSpeed;
    public float _gravity;
    public float _foodPoints;
    public bool _isAlive = true;
    
    

    Vector3 _moveDirection = Vector3.zero;

    CharacterController _char;
    // Start is called before the first frame update
    void Start()
    {
        _char = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if (_char.isGrounded)
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            _moveDirection *= _speed;        
            if (Input.GetButton("Jump"))
            {
                _moveDirection.y = _jumpSpeed;
            }
        }
        

        _moveDirection.y -= _gravity * Time.deltaTime;
        _char.Move(_moveDirection * Time.deltaTime);
    }
}
