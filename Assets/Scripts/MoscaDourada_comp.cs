﻿using UnityEngine;
using System.Collections;

public class MoscaDourada_comp : MonoBehaviour {
	
	public GameObject Moscas;
	
	private Vector2 mov;
	public Vector2 movimento = new Vector2 ( 0, 3);
	
	private float MinR = -2.4f;
	private float MaxR = 2.4f;
	
	protected Animator animator;
	
	
	void Start () {
		mov = movimento;
		GameObject CanvasGame = GameObject.Find ("CanvasGame");
		transform.parent = CanvasGame.transform;
		transform.SetAsFirstSibling();
		animator = GetComponent<Animator>();
		InvokeRepeating ("Zigzag", 0.2f, 0.2f);
		
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
	// Update is called once per frame
	void Update () {
		
		//movimentaçao
		rigidbody2D.velocity = mov;
		
		if (transform.position.x <= -2.7f) {
			mov.x = movimento.x;
			animator.SetBool("direita", true );
		} else if (transform.position.x >= 3f) {
			mov.x = -movimento.x;
			animator.SetBool("direita", false );
		}
		
		if (transform.position.y < -4.8f) {
			GameObject.Destroy(this.gameObject);
		}
	}
	
}
