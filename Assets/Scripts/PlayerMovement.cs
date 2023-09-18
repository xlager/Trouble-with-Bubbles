using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D projectile;
    public float xScreenMinimum, xScreenMaximum;
    private float playerSpeed = 5f;
    public float projectileSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterControl();
        Shot();
    }

    private void CharacterControl()
    {
        if (transform.position.x >= xScreenMinimum)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
            }
        }
        if (transform.position.x <= xScreenMaximum)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            }
        }
    }
    private void Shot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!projectile.gameObject.activeSelf)
            {
                projectile.gameObject.SetActive(true);
                projectile.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
                projectile.velocity = (Vector2.up * projectileSpeed);
                Debug.LogError(projectile.velocity.ToString());
            }
        }
    }
}
