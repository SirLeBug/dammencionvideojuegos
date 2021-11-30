using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter2 : MonoBehaviour
{
    public int healthfight;
    public string _nombre;
    public string _categoria;

    public Fighter2()
    {}

    public Fighter2(string nombre, string categoria)
    {
        healthfight = 100;
        _nombre = nombre;
        _categoria = categoria;
    }
        

    public string GetNombre()
    {
        return _nombre;
    }

    public void SetNombre(string nombre)
    {
        _nombre = nombre;
    }

    public string GetCategoria()
    {
        return _categoria;
    }

    public void SetCategoria(string categoria)
    {
        _categoria = categoria;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
