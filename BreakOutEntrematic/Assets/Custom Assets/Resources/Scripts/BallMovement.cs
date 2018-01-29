using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    //movement speed
    public float speed = 150.0f;

    void Start () {

        StartCoroutine(StartBouncing());
        
	}

    float hitFactor(Vector2 ballPos, Vector2 platformPos,
                float platformWidth)
    {
        return (ballPos.x - platformPos.x) / platformWidth;
    }

    IEnumerator StartBouncing()
    {
        yield return new WaitForSeconds(3.0f);
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    //function called when the Angry ball collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "platform")
        {
            // Calculate hit Factor
            float x = hitFactor(transform.position,
                              collision.transform.position,
                              collision.collider.bounds.size.x);

            // Calculate direction, set length to 1 so it always moves in an upward direction
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

}
