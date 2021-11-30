using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        float pos_x = transform.position.x;

        Debug.Log("[CUBO] Hola tengo la etiqueta " + tag + " con el nombre " + name);
        Debug.Log("[CUBO] La posicion x es " + pos_x);

        name = nombre;

        int i = 5;
        i = Suma(i);
        Debug.Log("i vale " + i);

        //inicializar una lista
        List<int> lista1 = new List<int>();
        lista1.Add(5);
        lista1.Add(4);
        lista1.Add(8);

        Debug.Log("El elemento de la posición 2 es: " + lista1[2]);
        Debug.Log("El tamaño de la lista es: " + lista1.Count);

        foreach (int elemento in lista1)
        {
            Debug.Log(elemento);
        }

        for (int elemento = 0; elemento < lista1.Count; elemento++)
        {
            Debug.Log(lista1[elemento]);
        }

        List<int> lista2 = new List<int>();
        lista2.Add(5);
        lista2.Add(4);
        lista2.Add(8);

        //Dice que es diferente por donde esta guardado en memoria
        if (lista1 == lista2)
        {
            Debug.Log("Las listas son iguales");
        } else
        {
            Debug.Log("Las listas no son iguales");
        }

        //ahora lista2 apunta a la memoria de lista1
        lista2 = lista1;

        lista1.Remove(4);

        Debug.Log(lista1.Count);
        Debug.Log(lista1[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Suma(int e)
    {
        e++;
        return e;
    }
}
