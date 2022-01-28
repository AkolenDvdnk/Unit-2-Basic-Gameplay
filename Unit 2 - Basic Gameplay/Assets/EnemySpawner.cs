using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay;

    public Transform[] spawnPoints;
    public GameObject enemy;
    //public List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; ; i++)
        {
            int point = Random.Range(0, spawnPoints.Length);
            GameObject enemy = Enemy(spawnPoints[point]);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
    private GameObject Enemy(Transform point)
    {
        //GameObject prefab = enemies[Random.Range(0, enemies.Count)];
       // return Instantiate(prefab, point.position, point.rotation);
        return Instantiate(enemy, point.position, point.rotation);
    }
}
