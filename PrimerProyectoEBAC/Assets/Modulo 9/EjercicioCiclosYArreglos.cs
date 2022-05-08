using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCiclosYArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 1
        int[] Arreglo1 = new int[5];
        int[] Arreglo2 = new int[5];
        int[] Arreglo3 = new int[5];
        for (int i = 0; i < Arreglo1.Length; i++)
        {
            Arreglo1[i] = Random.Range(0, 15);
            Arreglo2[i] = Random.Range(0, 15);
            Arreglo3[i] = Arreglo1[i] + Arreglo2[i];
            Debug.Log($"Valor de la posición {i} del Arreglo3 es {Arreglo1[i]} más {Arreglo2[i]} igual a {Arreglo3[i]}");
        }
        
        //Ejercicio 2
        string[] Palabras = new string[] {"Aprendiendo", "a","imprimir", "'Hola", "Mundo'", "por", "partes."};
        string oración = null;
        foreach (string j in Palabras)
        {
            oración += $" {j}";
        }
        Debug.Log(oración);

        //Ejercicio 3
        int[,] Matriz = new int[2, 3] { { 10, 5, 15 }, { 7, 12, 7 } };
        int[] Vector = new int[3] {1,1,1};
        int[] Resultado = new int[2];
        for (int x = 0; x < Matriz.GetLength(0); x++)
        {
            for (int y = 0; y < Matriz.GetLength(1); y++)
            {
                Resultado[x] += Matriz[x,y]*Vector[y];
            }
        }
        foreach (int r in Resultado) { Debug.Log(r); };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
