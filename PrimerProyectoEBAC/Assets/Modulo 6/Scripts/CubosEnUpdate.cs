using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosEnUpdate : MonoBehaviour
{
    public GameObject Prefabcubo;
    public List<GameObject> listadeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listadeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Prefabcubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(0.7f,0.7f,0.7f);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;


        listadeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }
        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCubos.Remove(go);
            Destroy(go);
        }
    }
}
