using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{

    public GameObject _startText;
    public GameObject _tutorialText;
    public void OnMouseDown()
    {
        _startText.SetActive(false);
        _tutorialText.SetActive(true);
    }
}
