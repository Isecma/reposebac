using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondCubo3 : MonoBehaviour
{
    public bool variableCubo3;
    public GameObject Cubo1;
    public GameObject Cubo2;
    bool boolCubo1;
    bool boolCubo2;
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
        boolCubo1 = Cubo1.GetComponent<CondCubo1>().variableCubo1;
        boolCubo2 = Cubo2.GetComponent<CondCubo2>().variableCubo2;
        variableCubo3 = ((boolCubo1 || boolCubo2) && boolCubo1);
        if (variableCubo3 == true)
        {
            Color blanco = Color.white;
            GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (variableCubo3 == false)
        {
            Color negro = Color.black;
            GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
