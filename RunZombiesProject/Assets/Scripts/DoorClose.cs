using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{

    PlayerController _player;

    public float _downSpeed;
    public bool _isFalling = false;
    public GameObject _door;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            _isFalling = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        IsFalling();
    }

   

    void IsFalling()
    {
        if(_isFalling == true)
        {
            _downSpeed += Time.deltaTime / 50;
            _door.transform.position = new Vector3(transform.position.x, transform.position.y - _downSpeed, transform.position.z);
        }
        
    }
}
