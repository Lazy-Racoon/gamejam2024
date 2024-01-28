using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MonoComportamiento : MonoBehaviour
{

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
            Instantiate(kakaPrefab, kakaOffSet.position, transform.rotation);

            enfriamiento=false;
        }
    }
}
