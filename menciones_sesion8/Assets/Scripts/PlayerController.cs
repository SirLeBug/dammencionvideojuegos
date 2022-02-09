using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(speed * movimiento, playerRB.velocity.y);
        //Debug.Log("Speed: " + speed);

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_SpriteRenderer.flipX = true;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpriteRenderer.flipX = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
