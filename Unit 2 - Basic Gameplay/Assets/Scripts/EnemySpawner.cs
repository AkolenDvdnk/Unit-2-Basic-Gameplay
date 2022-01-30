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
        StartCoroutine(SpawnEnemyTop()); 
    }
    private IEnumerator SpawnEnemyTop()
    {
        for (int i = 0; ; i++)
        {
            Vector3 spawnPointTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, transform.position.z);
            Vector3 rotationTop = new Vector3(0, 180, 0);
            Enemy(spawnPointTop, Quaternion.Euler(rotationTop));
            yield return new WaitForSeconds(spawnDelay);

            Vector3 spawnPointRight = new Vector3(28, 0, Random.Range(5, 18));
            Vector3 rotationRight = new Vector3(0, -90, 0);
            Enemy(spawnPointRight, Quaternion.Euler(rotationRight));
            yield return new WaitForSeconds(spawnDelay);

            Vector3 spawnPointLeft = new Vector3(-28, 0, Random.Range(5, 18));
            Vector3 rotationLeft = new Vector3(0, 90, 0);
            Enemy(spawnPointLeft, Quaternion.Euler(rotationLeft));
            yield return new WaitForSeconds(spawnDelay);

        }
    }
    private GameObject Enemy(Vector3 point, Quaternion quaternion)
    {
        int enemyIndex = Random.Range(0, enemies.Length);
        return Instantiate(enemies[enemyIndex], point, quaternion);
    }
}
