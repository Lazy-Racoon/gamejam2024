using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    public float speed = 10f;
    private float x,y,z;
    
    Vector2 decisionTime = new Vector2(1, 4);
    float decisionTimeCount = 0;

    Vector3[] moveDirections = new Vector3[] { new Vector3(0,0,1), new Vector3(0,0,-1) };
    int currentMoveDirection;

      private Rigidbody rb;
    private void Awake(){
      rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision) 
{
     if(gameObject.CompareTag("wall"))
        {
          rb.velocity = Vector3.zero;
        }
}


    // Start is called before the first frame update
    void Start()
    {
        //We can verify if the value of the monkey is the same when spacebar is pressed
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;
        decisionTimeCount = UnityEngine.Random.Range(decisionTime.x, decisionTime.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;
        transform.Translate(moveDirections[currentMoveDirection] * speed * Time.deltaTime);
        if (decisionTimeCount > 0) {
            decisionTimeCount -= Time.deltaTime;
        }        
        else
        {
            // Choose a random time delay for taking a decision ( changing direction, or standing in place for a while )
            decisionTimeCount = UnityEngine.Random.Range(decisionTime.x, decisionTime.y);
 
            // Choose a movement direction, or stay in place
            ChooseMoveDirection();
        }
    }

    void ChooseMoveDirection()
    {
        // Choose whether to move sideways or up/down
        currentMoveDirection = Mathf.FloorToInt(UnityEngine.Random.Range(0, moveDirections.Length));
    }
}
