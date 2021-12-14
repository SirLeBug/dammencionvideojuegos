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
    public List<Sprite> listOfSprites;
    int[] contador = { 0, 0, 0, 0, 0 };
    bool encontrado = false;
    int pos;

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

                encontrado = false;
                pos = 0;
                while (!encontrado)
                {
                    pos = Random.Range(0, 5);
                    if(contador[pos] < 2)
                    {
                        contador[pos] += 1;
                        encontrado = true;
                    }
                }

                nuevaCarta.GetComponent<CardScript>().front = listOfSprites[pos];

                listOfCards.Add(nuevaCarta);
                x += 3;
            } else
            {
                GameObject nuevaCarta = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                nuevaCarta.name = "card" + i;

                encontrado = false;
                pos = 0;
                while (!encontrado)
                {
                    pos = Random.Range(0, 5);
                    if (contador[pos] < 2)
                    {
                        contador[pos] += 1;
                        encontrado = true;
                    }
                }

                nuevaCarta.GetComponent<CardScript>().front = listOfSprites[pos];
                

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
