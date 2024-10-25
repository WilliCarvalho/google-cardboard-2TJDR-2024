using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Zumbi enemy;
    [SerializeField] private Vector3 minSpawnPosition;
    [SerializeField] private Vector3 maxSpawnPosition;

    [SerializeField] private float spawnTime = 1;

    private void Awake()
    {
        StartCoroutine(SpawnZombies());
    }

    private IEnumerator SpawnZombies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Vector3 spawnPosition = new Vector3(Random.Range(minSpawnPosition.x, maxSpawnPosition.x),
                0,
                Random.Range(minSpawnPosition.z,maxSpawnPosition.z)
                );

            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }
}
