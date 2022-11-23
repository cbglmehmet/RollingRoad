using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSoundEffect;

    private bool levelCompleted = false;

    // Start is called before the first frame update
    private void Start()
    {
        finishSoundEffect = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelCompleted)
        {
            if(PlayerPrefs.GetInt("Volume") == 1)
            {
                finishSoundEffect.Play();
            }
            
            levelCompleted = true;
            Invoke("CompleteLevel", 1.2f);
        }
    }
    private void CompleteLevel()
    {
        if(SceneManager.GetActiveScene().name == "Level 5")
        {
            SceneManager.LoadScene("start", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
