using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipScript : MonoBehaviour
{
    //public int speed;
    public int force;
    public int forceTorpedo;
    Rigidbody2D myRB;
    bool canShot = true;
    bool end = false;

    public GameObject torpedo;
    GameObject texto;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        texto = GameObject.FindGameObjectWithTag("Finish");
        texto.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!end)
        {
            float movement = Input.GetAxis("Horizontal");

            myRB.velocity = transform.right * movement * force;

            float xPos = Mathf.Clamp(myRB.position.x, -3.12f, 3.12f);

            myRB.position = new Vector2(xPos, transform.position.y);

            if (Input.GetButton("Jump") && canShot)
            {
                GameObject clone = Instantiate(torpedo, new Vector2(transform.position.x, -1.48f), Quaternion.identity);

                Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D>();

                Vector2 direccion = new Vector2(0f, 1f);

                cloneRB.AddForce(direccion * forceTorpedo);

                canShot = false;
            }
        }  

    }

    public void SetCanShot()
    {
        canShot = true;
    }

    public void SetEnd()
    {
        end = true;
        canShot = false;
    }

    public void SetTexto()
    {
        
        texto.GetComponent<Text>().text = "You Win";
        texto.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            SetEnd();
            texto.SetActive(true);
        }
        
    }
}
