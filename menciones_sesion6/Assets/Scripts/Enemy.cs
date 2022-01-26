using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D myRB;
    bool changedirection = false;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        //InvokeRepeating("MoveEnemy", 0.5f, 0.5f);
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);
        MoveEnemy();
        StartCoroutine(Wait());
    }
    void MoveEnemy()
    {
        if(myRB.position.x >= 3)
        {
            changedirection = true;
        } else if (myRB.position.x <= -3)
        {
            changedirection = false;
        }

        if (changedirection)
        {
            transform.Translate(Vector2.left);
        }
        else
        {
            transform.Translate(Vector2.right);
        }
    }
}
