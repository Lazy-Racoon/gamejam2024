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
        PersonaController person = Instantiate(mamaConBebe, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");

    }

    void GenerarNinoConGlobo()
    {
        PersonaController person = Instantiate(ninoConGlobo, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");
    }
    void GenerarCiego()
    {
        PersonaController person = Instantiate(ciego, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");
    }

    void GenerarVieja()
    {
        PersonaController person = Instantiate(vieja, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");
    }

    void GenerarRobot()
    {
        PersonaController person = Instantiate(robot, personajeOffSet.position, transform.rotation);
        person.SetPicture("vieja_cara");
    }
}
