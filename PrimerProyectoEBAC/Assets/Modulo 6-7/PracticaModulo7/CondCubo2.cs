using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondCubo2 : MonoBehaviour
{
    public bool variableCubo2;
    public GameObject Esfera;
    public GameObject Capsula;
    bool boolEsfera;
    bool boolCapsula;
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
        boolEsfera = Esfera.GetComponent<CondEsfera>().variableEsfera;
        boolCapsula = Capsula.GetComponent<CondCapsula>().variableCapsula;
        variableCubo2 = (boolEsfera || boolCapsula);
        if (variableCubo2 == true)
        {
            Color blanco = Color.white;
            GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (variableCubo2 == false)
        {
 
            Color negro = Color.black;
            GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
