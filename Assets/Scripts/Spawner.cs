using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

	public float maxWidth;
	public float minWidth;

	public float rateSpawn;

	private float currentRateSpawn;

	public int maxObject;

	public GameObject prefab;

	public List<GameObject> mosquito;

void Start () {
	for (int i=0; i < maxObject; i++){

		GameObject tempObject = Instantiate(prefab) as GameObject;
		mosquito.Add(tempObject);
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
			if (mosquito [i].activeSelf == false) {
				tempObject = mosquito [i];
				break;
			}

		}
			if (tempObject != null) {
				tempObject.transform.position = new Vector3 (randPosition, transform.position.y, transform.position.z);
				tempObject.SetActive (true);
			}

}
		
}