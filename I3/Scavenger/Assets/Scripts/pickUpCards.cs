using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickUpCards : MonoBehaviour
{

    public int cardCount;
    public GameObject Card;
    private int nbScenes;

    // Use this for initialization
    void Start()
    {
        cardCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("I am clicked");

        if (Card.gameObject.tag == "Arcane")
        {
            Card.gameObject.SetActive(false);
            cardCount = cardCount + 1;
            SceneManager.LoadScene("MainMenu");
        }

    }

}