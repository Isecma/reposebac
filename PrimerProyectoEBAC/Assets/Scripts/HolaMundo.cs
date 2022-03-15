using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola desde Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Hola desde Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("Hola desde FixedUpdate");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Hola desde LateUpdate");
    }
    private void OnEnable()
    {
        Debug.LogError("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.Log("El objeto ha sido inhabilitado");
    }
}
