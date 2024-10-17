using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraMarioFeos : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 3.0f;

    public GameObject marioFeo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f){
            
            Instantiate (marioFeo, transform.position, Quaternion.identity);
            time = 9999.9f;
        }
    }
}
