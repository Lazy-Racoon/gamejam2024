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
    public PersonaController hombre;
    public Transform personajeOffSet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarMama", 10.0f, 9.0f);
        InvokeRepeating("GenerarNinoConGlobo", 3.0f, 7.0f);
        InvokeRepeating("GenerarCiego", 5.0f, 7.0f);
        InvokeRepeating("GenerarVieja", 20.0f, 10.0f);
        InvokeRepeating("GenerarRobot", 15.0f, 7.0f);
        InvokeRepeating("GenerarHombre", 1.0f, 5.0f);
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
        CancelInvoke("GenerarHombre");
        }        
    }

    void GenerarMama()
    {
        PersonaController person = Instantiate(mamaConBebe, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");

    }

    void GenerarNinoConGlobo()
    {
        PersonaController person = Instantiate(ninoConGlobo, personajeOffSet.position, transform.rotation);
        person.SetPicture("nino_cara");
    }
    void GenerarCiego()
    {
        PersonaController person = Instantiate(ciego, personajeOffSet.position, transform.rotation);
        person.SetPicture("ciego_cara");
    }

    void GenerarVieja()
    {
        PersonaController person = Instantiate(vieja, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");
    }

    void GenerarRobot()
    {
        PersonaController person = Instantiate(robot, personajeOffSet.position, transform.rotation);
        person.SetPicture("robot_cara");
    }
    void GenerarHombre()
    {
        PersonaController person = Instantiate(hombre, personajeOffSet.position, transform.rotation);
        person.SetPicture("hombre_cara");
    }
}
