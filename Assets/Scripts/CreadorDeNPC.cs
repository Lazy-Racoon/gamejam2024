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
        InvokeRepeating("GenerarMama", 3.0f, 10.0f);
        InvokeRepeating("GenerarNinoConGlobo", 4.0f, 6.0f);
        InvokeRepeating("GenerarCiego", 1.0f, 4.0f);
        InvokeRepeating("GenerarVieja", 1.0f, 7.0f);
        InvokeRepeating("GenerarRobot", 1.0f, 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
