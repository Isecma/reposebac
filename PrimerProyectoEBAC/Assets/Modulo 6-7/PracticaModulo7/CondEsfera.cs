using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondEsfera : MonoBehaviour
{
    public bool variableEsfera = true;
  
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
        if (variableEsfera == true)
        {
            variableEsfera = false;
            Color blanco = Color.white;
            GetComponent<MeshRenderer>().material.color = blanco;
        }
        else if (variableEsfera == false)
        {
            variableEsfera = true;
            Color negro = Color.black;
            GetComponent<MeshRenderer>().material.color = negro;
        }
    }
}
