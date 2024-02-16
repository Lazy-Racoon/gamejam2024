using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PersonaController : MonoBehaviour
{
    public int scoreNPC;
    public float velocity;
    private TextMeshProUGUI scoreTExt;
    private Image profilePicture;
    private Image monkeyProfilePicture;
    private GameObject canvas;
    private GameObject profile;
    private GameObject monkeyprofile;
    private bool hurt = false;
    private float count = 0;
    private float TIMEMAX = 1f;
    private Sprite picture;
    private string picturePath;
    Sprite monkeyPicture;
    // Start is called before the first frame update
    
    private void Awake(){
      canvas = GameObject.FindGameObjectsWithTag("CanvasText")[0];
      //Only one element should use that tag
      profile = FindInActiveObjectByTag("personProfile");
      monkeyprofile = FindInActiveObjectByTag("monkeyProfile");
      scoreTExt = canvas.GetComponent<TextMeshProUGUI>();
      if(profile && monkeyprofile){
      profilePicture = profile.GetComponent<Image>();
      monkeyProfilePicture = monkeyprofile.GetComponent<Image>();
      }
    }

    public void SetPicture(string imagePath){
        //ProfileImage Should be in resource folder
        //picture = Resources.Load<Sprite>(imagePath);
        picturePath = imagePath;
    }

    void OnTriggerEnter2D(Collider2D element)
    {
        if (element.tag == "Kaka"){
            GetComponent<CapsuleCollider2D>().enabled = false;
            MonoComportamiento.score+= scoreNPC;  //  The code that any instance can use to cause the score to be incremented, since the playerScore variable is a Static member, all instances of this class will have access to its value regardless of what instance next updates it.
            scoreTExt.text = ""+MonoComportamiento.score;
            picture = Resources.Load<Sprite>(picturePath);
            profilePicture.sprite = picture;
            profile.SetActive(true);
            //monkeyprofile.SetActive(true);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            hurt = true;
            count = 0;    
        }            
    }

    void Start()
    {
        //Only one player, so should be the first
        //
        profile.SetActive(false);
        scoreTExt.text = ""+MonoComportamiento.score;
        profilePicture.sprite = picture;
        monkeyPicture = Resources.Load<Sprite>("score_mono");
        monkeyProfilePicture.sprite = monkeyPicture;
    }

    // Update is called once per frame
    void Update()
    {        
        if (ManagerController.gameover){
            // No Update On GameOver
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }
        if(hurt){
            
            hideProfileImage();
        }
        else{
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocity,0);
        }
    }

    GameObject FindInActiveObjectByTag(string tag){
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++){
            if (objs[i].hideFlags == HideFlags.None){
                if (objs[i].CompareTag(tag)){
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }

    void hideProfileImage(){        
            count += Time.deltaTime;
            //Hide Image
            if(count > TIMEMAX){
                profile.SetActive(false);
                monkeyprofile.SetActive(false);
                hurt = false;
            }                        
    }
}
