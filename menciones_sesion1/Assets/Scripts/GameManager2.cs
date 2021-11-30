using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public List<GameObject> e = new List<GameObject>();
    List<string> arrNombres = new List<string>() { "Scorpio", "Frost", "Xin", "Sailbot", "Khan" };
    List<string> arrCategoria = new List<string>() { "Ninja", "Samurai", "Crusader", "Samurai", "Ninja" };

    static void InitFighters(List<string> arrNombres, List<string> arrCategoria, List<GameObject> e)
    {
        int cont = 0;
        
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("fighter2"))
        {
            Fighter2 fighter = obj.GetComponent<Fighter2>();
            fighter.SetNombre(arrNombres[cont]);
            fighter.SetCategoria(arrCategoria[cont]);
            Debug.Log("El nombre del fighter " + (cont + 1) + " es: " + fighter.GetNombre());
            Debug.Log("La categoria del fighter " + (cont + 1) + " es: " + fighter.GetCategoria());
            cont++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("fighter2"))
        {
            e.Add(obj);
        }

        InitFighters(arrNombres, arrCategoria, e);
        //Fighter2 fighter = e.GetComponent<Fighter2>();
        //fighter.SetNombre("Scorpio");
        //Debug.Log(fighter.GetNombre());


        //Fighter2 fighter = new Fighter2();
        //fighter.nombre = "Scorpio";
        //fighter.categoria = "ninja";
        //Fighter2 fighter2 = new Fighter2();
        //fighter.nombre = "Scorpio";
        //fighter.categoria = "ninja";
        //Fighter fighter = e.GetComponent<Fighter>();
        //Debug.Log(fighter.nombre);
        //Debug.Log(fighter.categoria);
        //Debug.Log(fighter.healthfight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
