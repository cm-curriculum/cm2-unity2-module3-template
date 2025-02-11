using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZombieSpawnerScript : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform target;

    public float spawnRange = 10;

    public UnityEvent ZombieDied;

    void Start()
    {
        // LESSON 3-4: Replace code below.
        SpawnZombie();
    }

    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-spawnRange,spawnRange), 1, Random.Range(-spawnRange,spawnRange));
    }

    public void SpawnZombie()
    {
        // LESSON 3-3: Add code below.
    }

    public void ZombieHasDied()
    {
        ZombieDied?.Invoke();
    }

    // LESSON 3-4: Add coroutine below.
}
