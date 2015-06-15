using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

	public float speed;
	public GameObject Rocks;
	//Trigger de colisao
	void OnTriggerEnter2d(Collider2D collider){
				switch (collider.gameObject.name) {
				case "Spider":
						Application.LoadLevel ("Gameover");
						Debug.Log ("Gameover");
						break;
				}
		}

	void Start (){
				GameObject CanvasGame = GameObject.Find ("CanvasGame");
				transform.parent = CanvasGame.transform;
				transform.SetAsFirstSibling();
		}
	void Update () {
		//movimentaçao
		rigidbody2D.velocity = (new Vector2 (0, speed) * Time.deltaTime);
		if (transform.position.y < -4.8f) {
			GameObject.Destroy(Rocks);
		}
	}
	
}