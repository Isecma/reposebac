using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondCubo1 : MonoBehaviour
{
    public bool variableCubo1;
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
        variableCubo1 = (boolEsfera && boolCapsula);
        if (variableCubo1 == true)
        {
            Color blanco = Color.white;
            GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (variableCubo1 == false)
        {
            Color negro = Color.black;
            GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
