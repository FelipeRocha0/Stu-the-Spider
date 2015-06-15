using UnityEngine;
using System.Collections;

public class GenerateRock : MonoBehaviour {
	public float maxWidth;
	public float minWidth;
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject RockPrefab;

	private float direction = 100;

	public float TempoDeVida;

	
	void Start()
	{
		Invoke("Suicide", TempoDeVida);
	}
	

	void Update () {
		float up = 100;
		float down = -100;

		rigidbody2D.velocity = (new Vector2 (0, direction)*Time.deltaTime);
			if (transform.position.y <= 5) {
						direction = up;
				} else if (transform.position.y >= 20) {
						direction = down;
				}

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
			
			Instantiate(RockPrefab);
			RockPrefab.transform.position = new Vector2 (randPosition, transform.position.y);
		}
		
	}
	void Suicide() {
		Destroy (GameObject.Find("SpawnerRock(Clone)"));
	}
}