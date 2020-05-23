using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotaoOn : MonoBehaviour
{
    public bool _isRnage;
    public KeyCode _interectKey;
    public UnityEvent _interecAction;

    public int _isTurnOn;

    PlayerController _player;

    private void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (_isRnage == true)
        {
            if (Input.GetKeyDown(_interectKey))
            {
                
                _interecAction.Invoke();
                _isTurnOn += 1;
                
            }
        }
        
        

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            _isRnage = true;
        }
    }


}
