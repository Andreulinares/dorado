using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip sonidoMatar;
    private AudioSource fuenteAudio;
    void Start()
    {
        fuenteAudio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "NPC"){
            //Destroy(other.gameObject);
            Debug.Log("Colisión con NPC detectada");
            fuenteAudio.PlayOneShot(sonidoMatar);
        }
    }
}
