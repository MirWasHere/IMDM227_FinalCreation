using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public int numberToSpawn = 5;
    public Transform [] spawnPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCollectibles();
    }

    // Update is called once per frame
    void SpawnCollectibles()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(collectiblePrefab, randomPoint.position, randomPoint.rotation);
        }
        
    }
}