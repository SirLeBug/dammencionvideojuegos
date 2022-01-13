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
    int[] types = { 7, 1, 0, 9, 6 };
    int state = 0;
    int priorType;
    int priorIndex;

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
                nuevaCarta.GetComponent<CardScript>().tipo = types[pos];
                nuevaCarta.GetComponent<CardScript>().index = i;

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
                nuevaCarta.GetComponent<CardScript>().tipo = types[pos];
                nuevaCarta.GetComponent<CardScript>().index = i;


                listOfCards.Add(nuevaCarta);
                x += 3;
            }
        }
    }

    public void ClickOnCard(int t, int index)
    {
        Debug.Log("Clicked " + t);
        if(state == 1)
        {
            if(t == priorType)
            {
                Debug.Log("PAREJA!");
                //StartCoroutine(WaitAndPrint());
                listOfCards[index].SetActive(false);
                listOfCards[priorIndex].SetActive(false);
                //Destroy(listOfCards[index]);
                //Destroy(listOfCards[priorIndex]);
            }
            else
            {
                Debug.Log("No es pareja");
                StartCoroutine(WaitAndPrint(index));
                //listOfCards[index].GetComponent<CardScript>().Toggle();
                //listOfCards[priorIndex].GetComponent<CardScript>().Toggle();
            }
            state = 0;
        }
        else
        {
            priorType = t;
            priorIndex = index;
            state = 1;
        }
        
    }

    IEnumerator WaitAndPrint(int i)
    {
        Debug.Log("Antes del waitforseconds");
        yield return new WaitForSeconds(2);
        listOfCards[i].GetComponent<CardScript>().Toggle();
        listOfCards[priorIndex].GetComponent<CardScript>().Toggle();
        Debug.Log("Despues del waitforseconds");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
