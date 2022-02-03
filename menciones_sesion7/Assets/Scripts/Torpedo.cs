using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour
{
    GameObject spaceShip;
    SpaceShipScript scriptNave;

    // Start is called before the first frame update
    void Start()
    {
        //acceder al script de la nave para acceder al booleano para volver a disparar (ponerlo a true el canShot)
        spaceShip = GameObject.FindGameObjectWithTag("Player");
        scriptNave = spaceShip.GetComponent<SpaceShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He colisionado con " + collision.gameObject.tag);
        scriptNave.SetCanShot();
        Destroy(gameObject);
        if (collision.gameObject.tag == "enemy")
        {
            scriptNave.SetEnd();
            scriptNave.SetTexto();
        }
    }
}
