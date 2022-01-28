using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay;

    public GameObject[] enemies;

    private float spawnRangeX = 10;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; ; i++)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, transform.position.z);
            GameObject enemy = Enemy(spawnPoint);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
    private GameObject Enemy(Vector3 point)
    {
        int enemyIndex = Random.Range(0, enemies.Length);
        return Instantiate(enemies[enemyIndex], point, enemies[enemyIndex].transform.rotation);
    }
}
