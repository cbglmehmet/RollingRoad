using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Button PauseButton;
    [SerializeField] private GameObject GUI;
    private bool isShowing = false;
    // Start is called before the first frame update
    void Start()
    {
        PauseButton.onClick.AddListener(delegate () { buttonClicked(); });
    }

    private void buttonClicked()
    {
        if(isShowing)
        {
            isShowing = false;
            GUI.SetActive(false);
        }
        else
        {
            isShowing = true;
            GUI.SetActive(true);
        }
        
    }
}
