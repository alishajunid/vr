using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DoorRoomController : MonoBehaviour
{
    public GameObject doorObject;
    public Light roomLight;
    public AudioClip doorOpenAudio;   //
    private AudioSource audioSource;  // 

    private bool doorOpened = false;

    void Start()
    {
        // Make sure the light starts off
        if (roomLight != null)
            roomLight.enabled = false;

        // Setup AudioSource
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
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

        // Play the door open sound
        if (doorOpenAudio != null && audioSource != null)
        {
            audioSource.PlayOneShot(doorOpenAudio);
        }
        else
        {
            Debug.LogWarning("No door open audio clip assigned!");
        }

        doorOpened = true;
    }
}

