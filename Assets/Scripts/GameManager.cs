using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI vidaText;

    public GameObject player;

    public int vidas;

    public AudioSource aud;
    public AudioClip powerupSound;


    public void ActVidas(){
        vidaText.text = "Vidas: " + vidas;
    }

    public void CoolDownMario(){
        BoxCollider2D[] boxColliders = player.GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D boxCollider in boxColliders){
            boxCollider.enabled = false;
        }
        Invoke("ResetMario", 2.0f);
    }

    public void ResetMario(){
        BoxCollider2D[] boxColliders = player.GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D boxCollider in boxColliders){
            boxCollider.enabled = true;
        }
    }

    public void LoseLive(){
        vidas--;
        ActVidas();
        CoolDownMario();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        ActVidas();
        player = GameObject.Find("PlayerMario");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
