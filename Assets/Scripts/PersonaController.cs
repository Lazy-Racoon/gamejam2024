using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PersonaController : MonoBehaviour
{
    public float velocity;
    private TextMeshProUGUI scoreTExt;
    private Image profilePicture;
    private GameObject canvas;
    private GameObject profile;
    private bool hurt = false;
    // Start is called before the first frame update
    
    private void Awake(){
      canvas = GameObject.FindGameObjectsWithTag("CanvasText")[0];
      //Only one element should use that tag
      profile = FindInActiveObjectByTag("personProfile");
      scoreTExt = canvas.GetComponent<TextMeshProUGUI>();
      if(profile){
      profilePicture = profile.GetComponent<Image>();
      }
    }

    void OnTriggerEnter2D(Collider2D element)
    {
        if (element.tag == "Kaka"){
            MonoComportamiento.score++;  //  The code that any instance can use to cause the score to be incremented, since the playerScore variable is a Static member, all instances of this class will have access to its value regardless of what instance next updates it.
            scoreTExt.text = "Score: " + MonoComportamiento.score;
            profile.SetActive(true);
        }            
    }

    void Start()
    {
        //Only one player, so should be the first        
        scoreTExt.text = "Score: " + MonoComportamiento.score;        
    }

    // Update is called once per frame
    void Update()
    {        
        if (ManagerController.gameover){
            // No Update On GameOver
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }        
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity,0);
    }

    GameObject FindInActiveObjectByTag(string tag){
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].CompareTag(tag))
                {
                    return objs[i].gameObject;
                }
                }
            }
        return null;
    }
}
