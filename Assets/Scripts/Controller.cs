using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Variaveis
	public Vector2 VelAranha = new Vector2 (300, 0); 
	
	void Update () {
		if (transform.position.x <= -2.5f) {
			transform.position = new Vector3 (-2.5f, transform.position.y, transform.position.z);
		} else if (transform.position.x >= 2.5f) {
			transform.position = new Vector3 (2.5f, transform.position.y,transform.position.z);
		}
		Vector2 movimento = new Vector2 (Input.acceleration.x*110, 0);
		if (Time.timeScale == 1f) {
						rigidbody2D.AddForce (movimento);
						rigidbody2D.velocity *= 0.85f;
				} else {
				}

		
	}
}