using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakaComportamiento : MonoBehaviour
{
    public float speed = 3.5f;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
