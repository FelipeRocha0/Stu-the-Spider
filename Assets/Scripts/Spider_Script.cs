using UnityEngine;
using System.Collections;

public class Spider_Script : MonoBehaviour {
	
	//clips de audio
	public AudioClip Munch;
	public AudioClip Slurp;
	public AudioClip Bling;
	public AudioClip Hit;

	protected Animator animator;


	void Start(){
				animator = GetComponent<Animator> ();
		}

	//Triggers
	void OnTriggerEnter2D(Collider2D collider){
		switch(collider.gameObject.name){
		case "Mosca(Clone)":
			Destroy (GameObject.Find ("Mosca(Clone)"));
			audio.PlayOneShot(Slurp);
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			break;
		case "mosquito(Clone)":
			Destroy (GameObject.Find ("mosquito(Clone)"));
			Score.score++;
			audio.PlayOneShot(Munch);
			Debug.Log ("colisao mosquito");
			break;
		case "MoscaDourada(Clone)":
			Destroy (GameObject.Find ("MoscaDourada(Clone)"));
			audio.PlayOneShot(Bling);
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			Score.score++;
			break;
		case "Pedra(Clone)":
			AudioCtrl.StopSound();
			audio.PlayOneShot(Hit);
			animator.SetBool ("Viva", false);
			Invoke ("Gameover", 3f);
			break;
		}
	}
	void Gameover (){
				Application.LoadLevel ("Gameover");
	}
		}