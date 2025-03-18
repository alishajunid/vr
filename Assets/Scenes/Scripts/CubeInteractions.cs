using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hover()
    {
        Debug.Log("Hover");
    
    }

    public void Selected()
    {
        Debug.Log("selected");
        GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red);

    }

    public void Activated()
    {
        Debug.Log("Activated");

    }
}
