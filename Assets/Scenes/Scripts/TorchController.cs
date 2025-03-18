using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
  
    public void ToggleLight()
    {
        Light torchLight = GetComponentInChildren<Light>();
        if (torchLight.isActiveAndEnabled)
        {
            torchLight.enabled = false;
        }
        else
        {
            torchLight.enabled = true;
        }
    }
}

