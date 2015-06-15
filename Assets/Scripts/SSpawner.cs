using UnityEngine;
using System.Collections;

public class SSpawner : MonoBehaviour {
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject SpawnerPrefab;
	
	void Update () {

		//controlador de spawn
		currentRateSpawn += Time.deltaTime;
		if (currentRateSpawn > rateSpawn) {
			currentRateSpawn = 0;
			Spawn ();
		}
		
	}
	void Spawn()
	{
		
		for (int i=0; i < maxObject; i++) {
			
			Instantiate(SpawnerPrefab);
		}
		
	}

}