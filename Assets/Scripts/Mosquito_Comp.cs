using UnityEngine;
using System.Collections;

public class Mosquito_Comp : MonoBehaviour {

	public GameObject Mosquitos;

	private float MinR = -2.27f;
	private float MaxR = 2.27f;

	private Vector2 mov;
	public Vector2 movimento = new Vector2 ( 0, 3);

	protected Animator animator;

	void Start () {
		GameObject CanvasGame = GameObject.Find ("CanvasGame");
		transform.parent = CanvasGame.transform;
		transform.SetAsFirstSibling();
		animator = GetComponent<Animator>();
		mov = movimento;
		InvokeRepeating ("Zigzag", 2f, 2f);
	}
	void Zigzag (){
				float Gen = Random.Range (MinR, MaxR);
				if (transform.position.x > Gen) {
						mov.x = -movimento.x;
						animator.SetBool ("direita", false);
				} else if (transform.position.x < Gen) {
						mov.x = movimento.x;
						animator.SetBool ("direita", true);
				}
		}

	void Update () {
		//movimentaçao
		rigidbody2D.velocity = mov;
		
		if (transform.position.x <= -2.7f) {
			mov.x = movimento.x;
			animator.SetBool("direita", true );
		} else if (transform.position.x >= 2.7f) {
			mov.x = -movimento.x;
			animator.SetBool("direita", false );
		}
		
		//movimentaçao
		if (transform.position.y < -4.8f) {
			GameObject.Destroy(this.gameObject);
		
		}
	}

}
