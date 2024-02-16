using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.U2D;

public class MonoComportamiento : MonoBehaviour
{
    public GameObject spriteMono;
    public float velocity;
    public KakaComportamiento kakaPrefab;
    public Transform kakaOffSet;
    private bool enfriamiento;
    private float count = 0;
    public float TIMEMAX;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        
        enfriamiento = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!enfriamiento)
        {
            count += Time.deltaTime;
            //Hide Image
            if (count > TIMEMAX)
            {
                Instantiate(kakaPrefab, kakaOffSet.position, transform.rotation);
                spriteMono.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("NITO 1");
                enfriamiento = true;
                count = 0;
            }
        }
        if (ManagerController.gameover){
            // No Update On GameOver
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * velocity, GetComponent<Rigidbody2D>().velocity.y);
        lanzamiento();
    }
    void lanzamiento()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&enfriamiento)
        {
            spriteMono.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("NITO 2");
            

            enfriamiento=false;
        }
    }
}
