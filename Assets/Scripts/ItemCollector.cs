using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries++;
            
        }
        else if(collision.gameObject.CompareTag("Apple"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries+=1;
        }
        else if (collision.gameObject.CompareTag("Banana"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 2;
        }
        else if (collision.gameObject.CompareTag("Kiwi"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 2;
        }
        else if (collision.gameObject.CompareTag("Melon"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 3;
        }
        else if (collision.gameObject.CompareTag("Strawberry"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 3;
        }
        else if (collision.gameObject.CompareTag("Pineapple"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 3;
        }
        else if (collision.gameObject.CompareTag("Orange"))
        {
            if (PlayerPrefs.GetInt("Volume") == 1)
            {
                collectionSoundEffect.Play();
            }
            Destroy(collision.gameObject);
            cherries += 3;
        }

        

        cherriesText.text = "Score: " + cherries.ToString();
    }
}
