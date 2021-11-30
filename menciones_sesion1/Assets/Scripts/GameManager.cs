using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        e = GameObject.FindGameObjectWithTag("fighter");
        Fighter fighter = e.GetComponent<Fighter>();
        Debug.Log(fighter.nombre);
        Debug.Log(fighter.categoria);
        Debug.Log(fighter.healthfight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
