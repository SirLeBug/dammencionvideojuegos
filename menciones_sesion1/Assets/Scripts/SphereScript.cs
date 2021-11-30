using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float pos_x = transform.position.x;
        Debug.Log("[ESFERA] Hola tengo la etiqueta " + tag + " con el nombre " + name);
        Debug.Log("[ESFERA] La posicion x es " + pos_x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
