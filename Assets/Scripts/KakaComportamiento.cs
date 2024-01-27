using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class KakaComportamiento : MonoBehaviour
{
    public float speed = 3.5f;
    public int score;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
        //transform.position += transform.forward * Time.deltaTime * 6.5f;
    }

    private void OnTriggerEnter2D(Collider2D npc)
    {
        if (npc.gameObject.tag == "npc")
        { 
            Destroy(gameObject);
        }
        
        

    }
}
