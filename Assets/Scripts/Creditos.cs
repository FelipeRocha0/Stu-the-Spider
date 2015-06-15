using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Creditos : MonoBehaviour {
	public Vector2 speed;
	protected RectTransform rectT;
	// Use this for initialization
	void Start () {
		rectT = GetComponent <RectTransform> ();
		rigidbody2D.velocity = (speed*Time.deltaTime);
		Invoke ("stop", 1620f*Time.deltaTime);
	}
	void stop () {
				rigidbody2D.velocity = (new Vector2 (0, 0));
				Debug.Log ("test");
		}
}
