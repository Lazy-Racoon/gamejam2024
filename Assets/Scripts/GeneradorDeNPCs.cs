using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeNPCs : MonoBehaviour
{

    public PersonaController npcPrefab;
    public Transform ntpOffSet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generador", 2.0f, 5.0f);
        //abuela
        //mujer-carrito
        //niñoglobo
        //ciego
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    void generador()
    {
        Instantiate(npcPrefab, ntpOffSet.position, transform.rotation);
    }
}
