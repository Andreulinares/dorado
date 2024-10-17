using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public Transform puntoA;
    public Transform puntoB;

    private Rigidbody2D rb;
    private Vector2 posicion;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        puntoA = GameObject.Find("PuntoA").GetComponent<Transform>();
        puntoB = GameObject.Find("PuntoB").GetComponent<Transform>();

        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        posicion = new Vector2(puntoA.position.x, puntoA.position.y);
        rb.MovePosition(rb.position + posicion * Time.fixedDeltaTime * speed);
        //if (rb.position.x <= pointA.position.x){
    }
}
