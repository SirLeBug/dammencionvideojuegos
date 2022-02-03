using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("MoveEnemy", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rocket")
        {
            Destroy(gameObject);
        } 
    }
}
