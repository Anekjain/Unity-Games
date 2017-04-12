using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject BlockPrefab;
	public float timeToSpawn = 2f;
	public float timeIntervel = 1f;
	// Use this for initialization
	void Update () {
		if (Time.time >= timeToSpawn) {
			Spawning ();
			timeToSpawn = Time.time + timeIntervel;
		}
	}

	void Spawning() {
		int randomIndex = Random.Range (0, spawnPoints.Length);
		for (int i = 0; i < spawnPoints.Length; i++) {
			if (randomIndex != i) {
				Instantiate(BlockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
	

}
