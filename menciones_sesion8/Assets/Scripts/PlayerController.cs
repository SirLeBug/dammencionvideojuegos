using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float movimiento = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(speed * movimiento, playerRB.velocity.y);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
