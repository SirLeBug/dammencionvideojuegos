using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ejercicio 1
public class Ejercicio1 : MonoBehaviour
{
    public Sprite imagen;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = imagen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
