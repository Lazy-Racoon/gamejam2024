using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PersonaController : MonoBehaviour
{
    public float velocity;
    public TextMeshProUGUI scoreTExt;
    // Start is called before the first frame update
    
    private void Awake(){
      scoreTExt.text = "Score: ";
    }

    void OnTriggerEnter2D(Collider2D element)
    {
        if (element.tag == "Kaka"){
            MonoComportamiento.score++;  //  The code that any instance can use to cause the score to be incremented, since the playerScore variable is a Static member, all instances of this class will have access to its value regardless of what instance next updates it.
            scoreTExt.text = "Score: " + MonoComportamiento.score;
        }            
    }

    void Start()
    {
        //Only one player, so should be the first
    }

    // Update is called once per frame
    void Update()
    {        
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity,0);
    }
}
