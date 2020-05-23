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

    void NextScene()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
