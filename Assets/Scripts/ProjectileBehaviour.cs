using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("Collided with: " + collision.tag);
        if (collision.CompareTag("Walls"))
            gameObject.SetActive(false);
        if (collision.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
}
