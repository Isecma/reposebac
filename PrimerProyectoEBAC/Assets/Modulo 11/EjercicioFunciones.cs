using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EjercicioFunciones : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ejercicio 1:");
        ListaNum(3, 0, 20);

        Debug.Log("Ejercicio 2:");
        int[] numeros = new int[6] { 7, 3, 4, 1, 10, 24 };
        ArregloIntOrdenadoDesc(numeros);

        Debug.Log("Ejercicio 3:");
        List<string> lista = new List<string>() { "Rojo", "Blanco", "Negro", "Rojo", "Blanco" };
        EliminarRepetidos(lista);

        Debug.Log("Ejercicio 4:");
        Stack miPila = new Stack();
        miPila.Push("Ismael");
        miPila.Push("Echegaray");
        miPila.Push("Macías");
        PilaACola(miPila);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //1er Ejercicio
    public void ListaNum(int tamaño,int inferior,int superior)
    {
        int x;
        List<int> lista = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            x = Random.Range(inferior, superior);
            lista.Add(x);
            Debug.Log(lista[i]);
        }
    }

    //2do Ejercicio
    public void ArregloIntOrdenadoDesc(int[] arreglo)
    {
        var arrOrdenado = arreglo.OrderByDescending(x => x).ToArray();
        foreach (int j in arrOrdenado)
        {
            Debug.Log(j);
        }

    }

    //3er Ejercicio
    public void EliminarRepetidos(List<string> lista)
    {
        HashSet<string> sinRepetidos = new HashSet<string>(lista);
        foreach (string s in sinRepetidos)
        {
            Debug.Log(s);
        }
    }

    //4to Ejercicio
    public void PilaACola(Stack pila)
    {
        Queue miCola = new Queue();
        miCola.Enqueue(pila.Peek());
        Debug.Log($"Pop ({ pila.Pop()})");
        miCola.Enqueue(pila.Peek());
        Debug.Log($"Pop ({ pila.Pop()})");
        miCola.Enqueue(pila.Peek());
        Debug.Log($"Pop ({ pila.Pop()})");
        Debug.Log($"Dequeue ({miCola.Dequeue()})");
        Debug.Log($"Dequeue ({miCola.Dequeue()})");
        Debug.Log($"Dequeue ({miCola.Dequeue()})");

    }
}
