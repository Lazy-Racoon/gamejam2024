using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MonoComportamiento : MonoBehaviour
{

    public float velocity;
    public KakaComportamiento kakaPrefab;
    public Transform kakaOffSet;

    public static int score = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * velocity, GetComponent<Rigidbody2D>().velocity.y);
        lanzamiento();
    }
    void lanzamiento()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(kakaPrefab, kakaOffSet.position, transform.rotation);
        }
    }
}
