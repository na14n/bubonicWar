using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class spawner : MonoBehaviour
{
    // Array to hold the wave information
    public Wave[] waves;
    public GameObject player;
    public GameObject boundary;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Invoke("spawnNow", 5f);
    }

    public void spawnNow()
    {
        // GameObject player = GameObject.FindWithTag("Player");
        // Get the Spawner component on this GameObject
        spawner spawner = GetComponent<spawner>();
        // Start the spawner coroutine
        StartCoroutine(spawner.StartSpawning(player.transform));
    }

    // Function to spawn the monsters for a wave
    public IEnumerator SpawnWave(Wave wave, Transform target)
    {
        for (int i = 0; i < wave.numMonsters; i++)
        {
            // Generate a random position within a certain radius around the target
            Vector3 randomPos = target.position + new Vector3(Random.Range(-wave.spawnRadius, wave.spawnRadius), Random.Range(-wave.spawnRadius, wave.spawnRadius), 0);
            // Check if the random position is within the colliders of the boundary object
            if (IsInsideColliders(randomPos))
            {
                // Instantiate the monster prefab at the random position
                GameObject monster = Instantiate(wave.monsterPrefab, randomPos, Quaternion.identity);
            }
            else
            {
                // If the random position is not within the colliders, decrease the loop variable so that the loop will repeat and generate a new random position
                i--;
            }
            yield return new WaitForSeconds(wave.spawnInterval);
        }

        for (int i = 0; i < wave.numMonsters2; i++)
        {
            // Generate a random position within a certain radius around the target
            Vector3 randomPos = target.position + new Vector3(Random.Range(-wave.spawnRadius, wave.spawnRadius), Random.Range(-wave.spawnRadius, wave.spawnRadius), 0);
            // Check if the random position is within the colliders of the boundary object
            if (IsInsideColliders(randomPos))
            {
                // Instantiate the second monster prefab at the random position
                GameObject monster2 = Instantiate(wave.monsterPrefab2, randomPos, Quaternion.identity);
            }
            else
            {
                // If the random position is not within the colliders, decrease the loop variable so that the loop will repeat and generate a new random position
                i--;
            }
            yield return new WaitForSeconds(wave.spawnInterval);
        }
    }

    // Coroutine to control the spawner
    public IEnumerator StartSpawning(Transform target)
    {
        // Iterate through the waves in the array
        for (int i = 0; i < waves.Length; i++)
        {
            // Spawn the monsters for the current wave
            StartCoroutine(SpawnWave(waves[i], target));

            // Wait for the specified interval before moving on to the next wave
            yield return new WaitForSeconds(waves[i].waveInterval);
        }
    }

    public bool IsInsideColliders(Vector3 position)
    {
        // Get all colliders on the boundary gameObject
        Collider2D[] colliders = boundary.GetComponents<Collider2D>();

        // Iterate through each collider
        for (int i = 0; i < colliders.Length; i++)
        {
            // Check if the given position is within the current collider
            if (colliders[i].OverlapPoint(position))
            {
                // If the position is within the collider, return true
                return true;
            }
        }

        // If the position is not within any of the colliders, return false
        return false;
    }

    [System.Serializable]
    public class Wave
    {
        public GameObject monsterPrefab;
        public GameObject monsterPrefab2;
        public int numMonsters;
        public int numMonsters2;
        public float spawnInterval;
        public float waveInterval;
        public float spawnRadius;

    }

}

