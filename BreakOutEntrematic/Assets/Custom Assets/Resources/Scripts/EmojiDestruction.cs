﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiDestruction : MonoBehaviour {

    public GameObject BrickEmoji;

    //was to be used to instantiate the brick emojis automatically with a game manager 
    //but went for a different more efficient method instead
    //void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //       GameObject.Instantiate(BrickEmoji, new Vector2(i * 5.0F, 0), Quaternion.identity);
           
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D colinfo)
    {
        // destroys the emoji the ball collided into
        if (gameObject.tag == "BrickEmoji")
        {
            Destroy(gameObject);
        }
       
    }
}
