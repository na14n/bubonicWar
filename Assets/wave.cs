using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
[System.Serializable]
public class Wave
{
    public GameObject monsterPrefab;
    public int numMonsters;
    public float spawnInterval;
    public float waveInterval;
}

}
