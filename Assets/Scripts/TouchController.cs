using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{

    public GameObject torch;

    // Start is called before the first frame update
    public void InstantiateTorch()
    {

        Instantiate(torch, new Vector3(0,2,2), Quaternion.identity);
    }
}
