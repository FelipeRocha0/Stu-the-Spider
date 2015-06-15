using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RockSpawner : MonoBehaviour {

	public float maxWidth;
	public float minWidth;
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject prefab;
	
	public List<GameObject> Rock;
	

	void Start () {
		for (int i=0; i < maxObject; i++){
			
			GameObject tempObject = Instantiate(prefab) as GameObject;
			Rock.Add(tempObject);
			tempObject.SetActive(false);
		}
	}
	void Update () {
		currentRateSpawn += Time.deltaTime;
		if (currentRateSpawn > rateSpawn) {
			currentRateSpawn = 0;
			Spawn ();
		}
	}
	private void Spawn () {
		float randPosition = Random.Range (minWidth, maxWidth);
		
		GameObject tempObject = null;
		
		for (int i=0; i < maxObject; i++) {
			if (Rock [i].activeSelf == false) {
				tempObject = Rock [i];
				break;
			}
			
		}
		if (tempObject != null) {
			tempObject.transform.position = new Vector2 (randPosition, transform.position.y);
			tempObject.SetActive (true);
		}
		
	}
	
}