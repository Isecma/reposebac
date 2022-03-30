using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    //bool variable1;
    //bool variable2;
    //bool variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }
    // Start is called before the first frame update
    void Start()
    {
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        //variable1 = true;
        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("El color seleccionado es verde");
        //        break;
        //    case (int)SeleccionColor.azul when variable1 == true:
        //        Debug.Log("El color seleccionado es azul");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("El color seleccionado es blanco");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("El color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("Ese no es un color válido");
        //        break;

        //}
        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo"; //operador unario
        Debug.Log(resultado);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
