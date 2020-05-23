using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{

    public GameObject _startText;
    public GameObject _tutorialText;
    public void OnMouseDown()
    {
        _startText.SetActive(false);    //Set falso para o UI do Menu Principal
        _tutorialText.SetActive(true);     //set true para o UI do tutorial
    }
}
