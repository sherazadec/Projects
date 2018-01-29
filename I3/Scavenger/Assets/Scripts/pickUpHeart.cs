using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickUpHeart : MonoBehaviour
{
    public int heartCount;
    public GameObject Heart;
    private int nbScenes;

    // Use this for initialization
    void Start()
    {
        heartCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("I am clicked");

        if (Heart.gameObject.tag == "HeartPiece")
        {
            loadNextScene.heartActive = true;
            Heart.gameObject.SetActive(false);
            heartCount = heartCount + 1;
            
        }

    }

   
}