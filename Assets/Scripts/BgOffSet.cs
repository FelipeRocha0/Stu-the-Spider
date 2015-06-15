using UnityEngine;
using System.Collections;

public class BgOffSet : MonoBehaviour {
	public float speed;
	float pos = 0;

	void Start () {
		if (gameObject.name == "BackGround") {
		Invoke ("stop", 1620f*Time.deltaTime);
		}
	}
	public void stop () {
		speed = 0;
	}
	void Update () {
		pos += speed*Time.deltaTime;
		if (pos > 1.0f) 
						pos -= 0;
		renderer.material.mainTextureOffset = (new Vector2 (0, pos));
	}
}
