using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosEnEnableDisable : MonoBehaviour
{
    public GameObject Prefabcubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Instantiate<GameObject>(Prefabcubo);
        Prefabcubo.transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-6, 6), Random.Range(-6, 6));
    }
    private void OnDisable()
    {
        Instantiate<GameObject>(Prefabcubo);
        Prefabcubo.transform.position = new Vector3(Random.Range(-6,6), Random.Range(-6, 6), Random.Range(-6, 6));
    }
}
