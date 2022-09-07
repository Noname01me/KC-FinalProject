
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public float SpawningRate = 2f;
    public GameObject EnemyPrefab;
    public Transform[] SpawnPoints;
    public player player;

    private float LastSpawnTime;



    
    void Update()
    {
        if (LastSpawnTime + SpawningRate < Time.time)
        {
            if (player == null) return;

            var randomspawnpoint = SpawnPoints[Random.Range(0, SpawnPoints.Length - 1)];

            Instantiate(EnemyPrefab, randomspawnpoint.position, Quaternion.identity);

            LastSpawnTime = Time.time;

            SpawningRate *= 0.94f;

        }
    }
}
