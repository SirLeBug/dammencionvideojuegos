using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    bool frontal = false;
    SpriteRenderer myRenderer;
    public Sprite back;
    public Sprite front;

    private void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 pos = transform.position;

        //Vector3 newPos = new Vector3(5.0f, 2.0f, 0.0f);

        //transform.position = transform.position + Vector3.right;

        //transform.Translate(Vector3.right * 3);

        //Vector3 rotacion = new Vector3(0, 0, 15);

        //transform.Rotate(rotacion);

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 rotacion = new Vector3(0, 0, 15) * Time.deltaTime;

        //transform.Rotate(rotacion);

        
    }

    void OnMouseDown()
    {
        Debug.Log("He hecho click en la carta");
        if (frontal)
        {
            myRenderer.sprite = back;
        } else
        {
            myRenderer.sprite = front;
        }

        frontal = !frontal;
    }
}
