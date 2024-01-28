using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 60f;
    public GameObject endMessage;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "00:" + Mathf.FloorToInt(timer).ToString("D2");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= 0){
            timerText.text = "00:" + Mathf.FloorToInt(timer).ToString("D2");
            timer -= Time.deltaTime;
        }
    }
}
