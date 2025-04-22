using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRoomController : MonoBehaviour
{
    public GameObject doorObject;
    public Light roomLight;
    public float lightTargetIntensity = 1.5f;
    public float lightFadeSpeed = 2f;

    private bool doorOpened = false;

    void Start()
    {
        // Make sure the light starts off or low
        if (roomLight != null)
            roomLight.intensity = 0f;
    }

    void Update()
    {
        // If the door was opened, smoothly increase light intensity
        if (doorOpened && roomLight != null)
        {
            roomLight.intensity = Mathf.Lerp(roomLight.intensity, lightTargetIntensity, Time.deltaTime * lightFadeSpeed);
        }
    }

    public void OpenDoor()
    {
        // Deactivate the door object
        if (doorObject != null)
            doorObject.SetActive(false);

        // Flag to start lighting up the room
        doorOpened = true;
    }
}
