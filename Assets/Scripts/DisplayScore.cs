using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textScore = GetComponent<TextMeshProUGUI>();
        textScore.text = "Score: "+MonoComportamiento.score+"";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
