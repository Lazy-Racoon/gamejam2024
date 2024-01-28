using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeNPC : MonoBehaviour
{

    public PersonaController mamaConBebe;
    public PersonaController ninoConGlobo;
    public PersonaController ciego;
    public PersonaController vieja;
    public PersonaController robot;
    public Transform personajeOffSet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarMama", 7.0f, 10.0f);
        InvokeRepeating("GenerarNinoConGlobo", 3.0f, 6.0f);
        InvokeRepeating("GenerarCiego", 5.0f, 10.0f);
        InvokeRepeating("GenerarVieja", 13.0f, 10.0f);
        InvokeRepeating("GenerarRobot", 10.0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(ManagerController.gameover){
        //Stop Generating NPC
        CancelInvoke("GenerarMama");
        CancelInvoke("GenerarNinoConGlobo");
        CancelInvoke("GenerarCiego");
        CancelInvoke("GenerarVieja");
        CancelInvoke("GenerarRobot");
        }        
    }

    void GenerarMama()
    {
        Instantiate(mamaConBebe, personajeOffSet.position, transform.rotation);
    }

    void GenerarNinoConGlobo()
    {
        Instantiate(ninoConGlobo, personajeOffSet.position, transform.rotation);
    }
    void GenerarCiego()
    {
        Instantiate(ciego, personajeOffSet.position, transform.rotation);
    }

    void GenerarVieja()
    {
        Instantiate(vieja, personajeOffSet.position, transform.rotation);
    }

    void GenerarRobot()
    {
        Instantiate(robot, personajeOffSet.position, transform.rotation);
    }
}
