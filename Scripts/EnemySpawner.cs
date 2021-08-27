using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    
    float positionXlimit = 2.5f;
    float positionToSpawn;
    Vector2 spawnPosition;
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSpike()
    {
        positionToSpawn = Random.Range(-positionXlimit, positionXlimit);
        spawnPosition = new Vector2(positionToSpawn, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

    public void StartSpawning()
    {
        InvokeRepeating(nameof(SpawnSpike), 0.5f, 1f);
    }

    public void StopSpawning()
    {
        CancelInvoke(nameof(SpawnSpike));
    }
}
