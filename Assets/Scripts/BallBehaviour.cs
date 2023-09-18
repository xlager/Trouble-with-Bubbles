using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private float ballHeight;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        ballHeight = transform.position.y;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > ballHeight)
        {
            ballHeight = transform.position.y;
            Debug.LogError("Max Height: " + ballHeight.ToString());
        }
    }
}
