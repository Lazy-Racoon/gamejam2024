using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class MonkeyController : MonoBehaviour
{
    public float score = 0f;
    public float speed = 10f;
    private float x,y,z;
    private Rigidbody rb;

    private void Awake(){
      rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;    
    }

    // Update is called once per frame
    void Update()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;

        rb.velocity = new Vector3(Input.GetAxis("Horizontal")* speed, 0, Input.GetAxis("Vertical") * speed);

        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Tira kaka en"+ x+" "+y+" "+z);
         }
    }
}
