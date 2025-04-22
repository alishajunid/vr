using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractions : MonoBehaviour
{

    private Renderer polySurfaceRenderer;

    void Start()
    {
        // Find the child called "polySurface2"
        Transform polySurface = transform.Find("polySurface2");
        if (polySurface != null)
        {
            polySurfaceRenderer = polySurface.GetComponent<Renderer>();
        }

        if (polySurfaceRenderer == null)
        {
            Debug.LogWarning("No Renderer found on polySurface2 in " + gameObject.name);
        }
    }

    public void Hover()
    {
        Debug.Log(gameObject.name + " Hovered");
    }

    public void Selected()
    {
        Debug.Log(gameObject.name + " Selected");

        if (polySurfaceRenderer != null)
        {
            polySurfaceRenderer.material.color = Color.red;
        }
    }

    public void Activated()
    {
        Debug.Log(gameObject.name + " Activated");
    }
}
