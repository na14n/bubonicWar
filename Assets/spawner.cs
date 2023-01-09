using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
        // Array to hold the wave information
    public Wave[] waves;

    void Start()
    {
        // Get the Spawner component on this GameObject
        spawner spawner = GetComponent<spawner>();
        // Start the spawner coroutine
        StartCoroutine(spawner.StartSpawning());
    }

    // Function to spawn the monsters for a wave
    public IEnumerator SpawnWave(Wave wave)
    {
        for (int i = 0; i < wave.numMonsters; i++)
        {
            // Instantiate the monster prefab
            GameObject monster = Instantiate(wave.monsterPrefab, transform.position, Quaternion.identity);

            // Wait for the specified interval before spawning the next monster
            yield return new WaitForSeconds(wave.spawnInterval);
        }
    }

    // Coroutine to control the spawner
    public IEnumerator StartSpawning()
    {
        // Iterate through the waves in the array
        for (int i = 0; i < waves.Length; i++)
        {
            // Spawn the monsters for the current wave
            StartCoroutine(SpawnWave(waves[i]));

            // Wait for the specified interval before moving on to the next wave
            yield return new WaitForSeconds(waves[i].waveInterval);
        }
    }

    [System.Serializable]
    public class Wave
    {
        public GameObject monsterPrefab;
        public int numMonsters;
        public float spawnInterval;
        public float waveInterval;
    }
    
}

