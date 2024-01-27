using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class KakaComportamiento : MonoBehaviour
{
    public float speed = 3.5f;
    public int score;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
        
        //transform.position += transform.forward * Time.deltaTime * 6.5f;
    }
    private void FixedUpdate()
    {
        transform.localScale = new Vector3(transform.localScale.x - 0.005f, transform.localScale.y - 0.005f, transform.localScale.z - 0.005f);

    }

    private void OnTriggerEnter2D(Collider2D npc)
    {
        if (npc.gameObject.tag == "npc")
        { 
            Destroy(gameObject);
        }
        
        

    }
}
