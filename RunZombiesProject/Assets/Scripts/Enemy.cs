using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent _mob;
    public GameObject _player;
    public float _mobDistanceRun = 4f;

    public bool _isDamege = false;

    PlayerController _playerControl;
    Food _food;

    // Start is called before the first frame update
    void Start()
    {
        _mob = GetComponent<NavMeshAgent>();
        _playerControl = GameObject.Find("player").GetComponent<PlayerController>();
        _food = GameObject.Find("food").GetComponent<Food>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombieChase();
        

        if(_isDamege == true) //Se a variavel bool _isDamage for true chama a function Damage()
        {
            Damage();
            if (_playerControl._foodPoints <= 0) //Se os pontos do player em _player._foodPoints for menor ou igual a 0, seta a variavel bool _isDamage como falso, parando de chamar a function
            {
                _isDamege = false;
                _playerControl._isAlive = false;
            }
        }
    }

    void ZombieChase()
    {
        if (_playerControl._isAlive == true)
        {
            float _distance = Vector3.Distance(transform.position, _player.transform.position);
            if (_distance < _mobDistanceRun)
            {
                Vector3 _dirToPlayer = transform.position - _player.transform.position;
                Vector3 _newPos = transform.position - _dirToPlayer;
                _mob.SetDestination(_newPos);
            }
        }
    }
    //Function para diminir em -1 a quantidade de pontos que o jogador tem;
    void Damage()
    {
        _playerControl._foodPoints -= 1;
        _food._pointText.text = _playerControl._foodPoints.ToString();
        
        
    }
    //Se o zombie colidir com objeto chamado player, seta a variavel bool como true
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "player")
        {
            _isDamege = true;
        }
    }
}
