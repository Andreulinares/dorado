using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{

    [SerializeField]
    float speed = 8f;

    int score;

    int vida;

    GameObject objetoVacio;
    
    // Start is called before the first frame update
    void Start()
    {
        /*score=100;
        Debug.Log(score);

        objetoVacio = GameObject.Find("vacio");
        Debug.Log(objetoVacio.name);

        //GameObject player = new GameObject("Player");

        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();*/
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");


        gameObject.transform.Translate(horizontal*Time.deltaTime*speed, vertical*Time.deltaTime*speed, 0);
        
    }
}
