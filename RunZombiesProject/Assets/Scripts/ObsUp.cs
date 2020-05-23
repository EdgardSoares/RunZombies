using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObsUp : MonoBehaviour
{

    public float _speed;
    public float _delta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        float y = Mathf.PingPong(_speed * Time.time, _delta);
        Vector3 _pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = _pos;
    }
}
