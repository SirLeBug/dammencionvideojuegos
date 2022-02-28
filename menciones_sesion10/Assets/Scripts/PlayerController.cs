using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    //SpriteRenderer m_SpriteRenderer;
    bool faceRight = true;
    Animator myAnim;
    public float jumpForce;
    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //m_SpriteRenderer = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
        Physics2D.queriesStartInColliders = false;
    }

    private void FixedUpdate()
    {

        myAnim.SetFloat("VerticalVelocity", playerRB.velocity.y);
        Debug.Log("Velocidad en Y " + playerRB.velocity.y);

        if (Input.GetAxis("Jump") > 0 && isGrounded==true)
        {
            playerRB.velocity = (new Vector2(playerRB.velocity.x, 0));
            playerRB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            myAnim.SetBool("IsGrounded", false);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

        if(hit.collider != null && isGrounded == false && playerRB.velocity.y < 0 && hit.collider.gameObject.tag == "Floor")
        {
            
            if(hit.distance < 0.4)
            {
                //Debug.Log("Detecto un objeto " + hit.collider.gameObject.name + " a distancia " + hit.distance);
                isGrounded = true;
                myAnim.SetBool("IsGrounded", true);
               
            }

        }

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
        myAnim.SetFloat("MoveSpeed", Mathf.Abs(movimiento));
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
