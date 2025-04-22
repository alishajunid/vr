using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorRoomController : MonoBehaviour
{
    public GameObject doorObject;
    public Light roomLight;

    private bool doorOpened = false;

    void Start()
    {
        // Make sure the light starts off
        if (roomLight != null)
            roomLight.enabled = false;
    }

    public void OpenDoor()
    {
        Debug.Log("OpenDoor() called!");

        // Disable the door object
        if (doorObject != null)
            doorObject.SetActive(false);

        // Enable the room light
        if (roomLight != null)
            roomLight.enabled = true;

        doorOpened = true;
    }
}
