using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuerpoMario : MonoBehaviour
{

    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "NPC"){
            gm.GetComponent<GameManager>().LoseLive();
        }
    }
}
