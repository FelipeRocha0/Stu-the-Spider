using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawnerception : MonoBehaviour {

	public float maxWidth;
	public float minWidth;
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject prefab;
	
	public List<GameObject> Spawner;
	
	void Start () {
		for (int i=0; i < maxObject; i++){
			
			GameObject tempObject = Instantiate(prefab) as GameObject;
			Spawner.Add(tempObject);
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
		
		GameObject tempObject = null;
		
		for (int i=0; i < maxObject; i++) {
			if (Spawner [i].activeSelf == false) {
				tempObject = Spawner [i];
				break;
			}
			
		}
		if (tempObject != null) {
			tempObject.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			tempObject.SetActive (true);
		}
		
	}
	
}