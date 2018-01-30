using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDeath : MonoBehaviour {

    //private bool isInDeathZone = false;
    public Transform startLocation;
    private int lives = 3;
    public GameObject AngryBall;

    private void Start()
    {
        AngryBall = GameObject.FindGameObjectWithTag("AngryBall");
    }

 
    private void OnTriggerEnter2D(Collider2D col)
    {
        lives -= 1;
        Debug.Log("I lost a life");

        if (col.gameObject.tag == "DeathZone")
        {
            transform.position = startLocation.position;
            Debug.Log("I'm respawning");
        }
       
        //if (lives == 0)
        //{
        //    //SceneManager.LoadScene("GameOver");
        //    //print("Game Over");
        //}

    }
}
