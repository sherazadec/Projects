using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDeath : MonoBehaviour
{
    //public Transform startLocation;
    public GameObject AngryBall;

    private void Start()
    {
        AngryBall = GameObject.FindGameObjectWithTag("AngryBall");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.LoseLife();
        //AngryBall.transform.position = startLocation.position;
        Debug.Log("I'm respawning");
    }
}
