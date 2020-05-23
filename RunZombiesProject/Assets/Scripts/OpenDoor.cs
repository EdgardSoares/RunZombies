using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    BotaoOn _botaoLigado;
    public float _doorOpenSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _botaoLigado = GameObject.Find("Led").GetComponent<BotaoOn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_botaoLigado._isTurnOn == 3)
        {
            _doorOpenSpeed += Time.deltaTime / 30;
            transform.position = new Vector3(transform.position.x, transform.position.y + _doorOpenSpeed, transform.position.z);
        }
    }
}
