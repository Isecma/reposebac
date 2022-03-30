using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaModulo7 : MonoBehaviour
{
    bool VariableCapsula = true;
    bool VariableEsfera = true;
    bool VariableCubo1;
    bool VariableCubo2;
    bool VariableCubo3;
    public GameObject Cubo1;
    public GameObject Cubo2;
    public GameObject Cubo3;
    public GameObject Esfera;
    public GameObject Capsula;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //Primer GO
        if (VariableCapsula == true)
        {
            VariableCapsula = false;
            Color blanco = Color.white;
            Capsula.GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (VariableCapsula == false)
        {
            VariableCapsula = true;
            Color negro = Color.black;
            Capsula.GetComponent<MeshRenderer>().material.color = negro;
        }
        //Segundo GO (el color es el mismo que el primer GO)
        if (VariableEsfera == true)
        {
            VariableEsfera = false;
            Color blanco = Color.white;
            Esfera.GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (VariableEsfera == false)
        {
            VariableEsfera = true;
            Color negro = Color.black;
            Esfera.GetComponent<MeshRenderer>().material.color = negro;
        }
        //Tercer GO (el color es el contrario al primer y segundo GO con AND)
        VariableCubo1 = (VariableCapsula && VariableEsfera);
        if (VariableCubo1 == true)
        {
            Color blanco = Color.white;
            Cubo1.GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (VariableCubo1 == false)
        {
            Color negro = Color.black;
            Cubo1.GetComponent<MeshRenderer>().material.color = negro;
        }
        //Cuarto GO (el color es el contrario al primer y segundo GO con OR)
        VariableCubo2 = (VariableCapsula || VariableEsfera);
        if (VariableCubo2 == true)
        {
            Color blanco = Color.white;
            Cubo2.GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (VariableCubo2 == false)
        {
            Color negro = Color.black;
            Cubo2.GetComponent<MeshRenderer>().material.color = negro;
        }
        //Quinto GO (el color va a la par que el tercer y cuarto GO)
        VariableCubo3 = (VariableCubo1 || VariableCubo2);
        if (VariableCubo3 == true)
        {
            Color blanco = Color.white;
            Cubo3.GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (VariableCubo3 == false)
        {
            Color negro = Color.black;
            Cubo3.GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
