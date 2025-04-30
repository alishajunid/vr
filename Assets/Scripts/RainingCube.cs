using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingCube : MonoBehaviour

{
    public GameObject manPrefab;
    public int spawnCount = 50;
    public Vector3 spawnAreaCenter;
    public Vector3 spawnAreaSize;

    public AudioClip rainingAudio;
    private AudioSource audioSource;

    void Start()
    {
        // Get or add an AudioSource component on this object
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    

    public void StartRain()
    {
        Debug.Log("Raining men!");

        // Play the rain audio
        if (rainingAudio != null)
        {
            audioSource.PlayOneShot(rainingAudio);
        }
        else
        {
            Debug.LogWarning("No rain audio assigned!");
        }



        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 randomPosition = spawnAreaCenter + new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2),
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            Instantiate(manPrefab, randomPosition, Quaternion.identity);
          
        }
    }
}