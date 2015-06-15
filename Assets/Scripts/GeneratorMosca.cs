using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GeneratorMosca : MonoBehaviour {
	public float maxWidth;
	public float minWidth;
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject MoscaPrefab;

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
		float randPosition = Random.Range (minWidth, maxWidth);
		for (int i=0; i < maxObject; i++) {
			
			Instantiate(MoscaPrefab);
			MoscaPrefab.transform.position = new Vector2 (randPosition, transform.position.y);


		}
		
	}
}