using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    //SpriteRenderer m_SpriteRenderer;
    bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Horizontal");
        
        //Debug.Log("Speed: " + speed);

        if (movimiento > 0 && !faceRight)
        {
            Turn();
        }
        else
        {

        }
        if (movimiento < 0 && faceRight)
        {
            Turn();
        }

        playerRB.velocity = new Vector2(speed * movimiento, playerRB.velocity.y);

    }

    void Turn()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        faceRight = !faceRight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
