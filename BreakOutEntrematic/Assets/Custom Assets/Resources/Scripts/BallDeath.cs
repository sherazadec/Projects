using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDeath : MonoBehaviour {

    private bool isInDeathZone = false;
    
    private int lives = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInDeathZone = true;
        print("You Lose");
        lives -= 1;

        if (lives <= 0)
        {
            //SceneManager.LoadScene("GameOver");
            print("Game Over");
        }

    }
}
