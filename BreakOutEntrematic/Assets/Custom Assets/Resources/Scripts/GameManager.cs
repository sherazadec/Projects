using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int lives = 3;
    public int BrickEmoji = 24;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject brickEmojiPrefab;
    public GameObject platform;
    public GameObject deathParticles;
    public static GameManager instance = null;

    public GameObject clonePlatform;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();

    }

    public void Setup()
    {
        clonePlatform = Instantiate(platform, transform.position, Quaternion.identity) as GameObject;
        Instantiate(brickEmojiPrefab, transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (BrickEmoji < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }

        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }

    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    public void LoseLife()
    {
        livesText.text = "Lives: " + --lives;
        
        
        Instantiate(deathParticles, clonePlatform.transform.position, Quaternion.identity);
        Destroy(clonePlatform);
        Invoke("SetupPlatform", resetDelay);
        CheckGameOver();
    }

    void SetupPlatform()
    {
        clonePlatform = Instantiate(platform, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        BrickEmoji--;
        CheckGameOver();
    }
}
