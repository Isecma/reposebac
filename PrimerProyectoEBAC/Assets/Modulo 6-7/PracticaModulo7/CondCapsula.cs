using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondCapsula : MonoBehaviour
{
    public bool variableCapsula = true;
    
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
        if (variableCapsula == true)
        {
            variableCapsula = false;
            Color blanco = Color.white;
            GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (variableCapsula == false)
        {
            variableCapsula = true;
            Color negro = Color.black;
            GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
