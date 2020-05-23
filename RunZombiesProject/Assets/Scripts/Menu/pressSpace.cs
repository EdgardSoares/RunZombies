using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressSpace : MonoBehaviour
{
    
    void Update()
    {
        NextScene();
    }


    // Ao pressionar a tecla Spacebar do teclado, é chamado a scene SampleScene onde o jogo começa
    void NextScene()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
