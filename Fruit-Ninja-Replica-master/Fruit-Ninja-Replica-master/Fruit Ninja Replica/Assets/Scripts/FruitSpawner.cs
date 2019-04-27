using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
    public GameObject bombPrefab;
	public Transform[] spawnPoints;

	public static float minDelay = .1f;
	public static float maxDelay = 1f;
    public static float minObstacleDelay = 1f;
    public static float maxObstacleDelay = 2f;

    // Use this for initialization
    void Start () {
		StartCoroutine(SpawnFruits());
        StartCoroutine(SpawnBombs());
	}

	IEnumerator SpawnFruits ()
	{
		while (true)
		{
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
			Destroy(spawnedFruit, 5f);
		}
	}
    IEnumerator SpawnBombs ()
    {
        while (true)
        {
            float delay = Random.Range(minObstacleDelay, maxObstacleDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            
            GameObject spawnedObstacle = Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);
            
            Destroy(spawnedObstacle, 5f);
        }
    }

}
