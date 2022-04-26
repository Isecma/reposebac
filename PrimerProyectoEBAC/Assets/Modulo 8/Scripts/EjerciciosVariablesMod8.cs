using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int entero = 0;
    float flotante = 1;
    float flot1 = 3.2f;
    float flot2 = 1.5f;
    int numero = 1;
    string mil = "1000";
    string dosmil = "2000";
    int num1;
    int num2;
    public GameObject Cubo;
    string palabra = "blanco";
    // Start is called before the first frame update
    void Start()
    {
        int resultado = (int)(flot1 + flot2);
        Debug.Log("Resultado de suma de floats en entero: " + resultado);

        float digitos = 3.14159265f;
        string res = digitos.ToString();
        Debug.Log("Resultado de float a string: " + res.Substring(0, 6));

        string nombre = "Ismael Echegaray Macías";
        Debug.Log("Nombre: " + nombre.Substring(0, 6));
        Debug.Log("Apellido Paterno: " + nombre.Substring(7, 9));
        Debug.Log("Apellido Materno: " + nombre.Substring(17, 6));

        string[] lista = nombre.Split(' ');
        foreach (var elem in lista)
        {
            Debug.Log("Lista: " + elem);
        }

        int.TryParse(mil, out num1);
        int.TryParse(dosmil, out num2);
        Debug.Log($"Str a Int usando TryParse: {num1+num2}");

        string oracion = "Hola mundo";
        char[] Array = oracion.ToCharArray();
        for (int i = 0; i < Array.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(Array[i]);
            }
        }

        string oracion2 = "Hello World";
        Debug.Log(oracion2.Remove(0, 5));

    }

    // Update is called once per frame
    void Update()
    {
        entero += 5;
        Debug.Log("Valor de entero: " + entero);
    }
    private void FixedUpdate()
    {
        flotante *= 2;
        Debug.Log("Valor de flotante: " + flotante);

        if (numero % 2 == 0)
        {
            Color blanco = Color.white;
            this.GetComponent<MeshRenderer>().material.color = blanco;
            Debug.Log("Mi número es par");
        }
        else
        {
            Color negro = Color.black;
            this.GetComponent<MeshRenderer>().material.color = negro;
            Debug.Log("Mi número es impar");
        }
        numero += 1;

        switch (palabra)
        {
            case "negro":
                Color negro = Color.black;
                Cubo.GetComponent<MeshRenderer>().material.color = negro;
                Debug.Log("El color del cubo es negro");
                palabra = "blanco";
                break;
            case "blanco":
                Color blanco = Color.white;
                Cubo.GetComponent<MeshRenderer>().material.color = blanco;
                Debug.Log("El color del cubo es blanco");
                palabra = "negro";
                break;
        }
    }
}
