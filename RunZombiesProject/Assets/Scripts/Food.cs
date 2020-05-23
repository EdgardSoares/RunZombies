using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    
    private float _speed = 0.5f;
    private float _delta = 0.5f;

    public Text _pointText;

    PlayerController _player;


    private void Start()
    {
        _player = GameObject.Find("player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(_speed * Time.time, _delta);
        Vector3 _pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = _pos;

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "player")
        {
            _player._foodPoints += 1;
            _pointText.text = _player._foodPoints.ToString();    //Adicionando na variavel _foodPoints no Script PlayerController os pontos obtidos ao player coletar
            Destroy(gameObject);
        }
    }
}
