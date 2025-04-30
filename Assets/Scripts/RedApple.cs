using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedApple : MonoBehaviour
{


    private Renderer polySurfaceRenderer;
    public Material redMaterial;

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

        if (polySurfaceRenderer != null && redMaterial != null)
        {
            polySurfaceRenderer.material = redMaterial;
        }
    }

    public void Activated()
    {
        Debug.Log(gameObject.name + " Activated");
    }
}
