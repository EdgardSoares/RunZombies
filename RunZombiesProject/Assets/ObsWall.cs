using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsWall : MonoBehaviour
{
    public float _speed = 1;
    public float _delta = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.PingPong(_speed * Time.time, _delta);
        Vector3 _pos = new Vector3(transform.position.x, transform.position.y, z);
        transform.position = _pos;

    }
}
