using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    //public int speed;
    public int force;
    public int forceTorpedo;
    Rigidbody2D myRB;

    public GameObject torpedo;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        //if(movement != 0)
        //{
           //transform.Translate(movement, 0, 0);
        //}

        myRB.velocity = transform.right * movement * force;

        float xPos = Mathf.Clamp(myRB.position.x, -3.12f, 3.12f);

        myRB.position = new Vector2(xPos, transform.position.y);

        if (Input.GetButton("Jump"))
        {
            GameObject clone = Instantiate(torpedo, new Vector2(transform.position.x, -1.62f), Quaternion.identity);

            Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D>();

            Vector2 direccion = new Vector2(0f, 1f);

            cloneRB.AddForce(direccion * forceTorpedo);
        }


    }
}
