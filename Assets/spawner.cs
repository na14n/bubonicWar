using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject rat;
    public GameObject bigRat;
    public GameObject flea;
    public GameObject bigFlea;
    public float timetoSpawnSmall = 5f;
    public float timetoSpawnBig = 10f;
    float elapsedTimeSmall;
    float elapsedTimeBig;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


        IEnumerator SpawnPrefabRat(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Instantiate(enemy, this.transform.position, Quaternion.identity);
        StartCoroutine(SpawnPrefabRat(interval, enemy));
    }
}
