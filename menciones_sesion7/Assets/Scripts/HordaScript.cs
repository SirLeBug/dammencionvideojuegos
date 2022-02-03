using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordaScript : MonoBehaviour
{
    Rigidbody2D myRB;
    bool toright = false;
    float sleep = 0.8f;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(sleep);
        MoveEnemy();
        StartCoroutine(Wait());
    }
    void MoveEnemy()
    {
        if (canMove)
        {
            if (!toright)
            {
                if (myRB.position.x >= 6)
                {
                    toright = true;
                    if (sleep > 0.1f)
                    {
                        sleep -= 0.05f;
                    }
                    transform.Translate(Vector2.down);
                }
                else
                {
                    transform.Translate(Vector2.right);
                }
            }
            else
            {
                if (myRB.position.x <= 2)
                {
                    toright = false;
                    if (sleep > 0.1f)
                    {
                        sleep -= 0.05f;
                    }
                    transform.Translate(Vector2.down);
                }
                else
                {
                    transform.Translate(Vector2.left);
                }
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canMove = false;
        }
    }
}
