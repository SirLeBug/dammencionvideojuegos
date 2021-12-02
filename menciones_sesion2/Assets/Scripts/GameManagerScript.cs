using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ejercicio 2
public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> listOfCards = new List<GameObject>();
    public int x = -8;
    public int y = 3;
    public int z = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                y = -3;
                x = -8;
            }
            if (i < 5)
            {
                GameObject nuevaCarta = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                nuevaCarta.name = "card" + i;
                listOfCards.Add(nuevaCarta);
                x += 3;
            } else
            {
                
                GameObject nuevaCarta = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                nuevaCarta.name = "card" + i;
                listOfCards.Add(nuevaCarta);
                x += 3;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
