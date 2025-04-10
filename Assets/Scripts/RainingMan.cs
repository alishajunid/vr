using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingMan : MonoBehaviour
{
    public GameObject manPrefab;       // Your falling man prefab
    public int numberOfMen = 10;       // How many men to spawn
    public float spawnHeight = 20f;    // How high they fall from
    public float spawnAreaSize = 10f;  // Width and depth of spawn area
    public float spawnDelay = 0.1f;    // Delay between spawns

    void Start()
    {
        StartCoroutine(SpawnMen());
    }

    IEnumerator SpawnMen()
    {
        for (int i = 0; i < numberOfMen; i++)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(-spawnAreaSize, spawnAreaSize),
                spawnHeight,
                Random.Range(-spawnAreaSize, spawnAreaSize)
            );

            Instantiate(manPrefab, randomPos, Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}