using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSettings : MonoBehaviour
{
    [SerializeField] private Button Level1;
    [SerializeField] private Button Level2;
    [SerializeField] private Button Level3;
    [SerializeField] private Button Level4;
    [SerializeField] private Button Level5;
    [SerializeField] private Button Exit;
    [SerializeField] private Button Sound;
    private AudioSource track;
    // Start is called before the first frame update
    void Start()
    {
        track = GetComponent<AudioSource>();
        int volume = PlayerPrefs.GetInt("Volume", 1);
        if (volume == 1)
        {
            track.Play();
        }
        else
        {
            track.Stop();
        }

        Level1.onClick.AddListener(delegate () { buttonClicked("Level1"); });
        Level2.onClick.AddListener(delegate () { buttonClicked("Level2"); });
        Level3.onClick.AddListener(delegate () { buttonClicked("Level3"); });
        Level4.onClick.AddListener(delegate () { buttonClicked("Level4"); });
        Level5.onClick.AddListener(delegate () { buttonClicked("Level5"); });
        Exit.onClick.AddListener(delegate () { buttonClicked("Exit"); });
        Sound.onClick.AddListener(delegate () { buttonClicked("Sound"); });
    }

    private void buttonClicked(string buttonName)
    {
        switch (buttonName)
        {
            case "Level1":
                SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
                break;
            case "Level2":
                SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
                break;
            case "Level3":
                SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
                break;
            case "Level4":
                SceneManager.LoadScene("Level 4", LoadSceneMode.Single);
                break;
            case "Level5":
                SceneManager.LoadScene("Level 5", LoadSceneMode.Single);
                break;
            case "Exit":
                Application.Quit();
                break;
            case "Sound":
                int volume = PlayerPrefs.GetInt("Volume");

                if (volume == 1)
                {
                    PlayerPrefs.SetInt("Volume", 0);
                    track.Stop();
                }
                else
                {
                    PlayerPrefs.SetInt("Volume", 1);
                    track.Play();
                }

                PlayerPrefs.Save();


                break;
        }

    }
}
