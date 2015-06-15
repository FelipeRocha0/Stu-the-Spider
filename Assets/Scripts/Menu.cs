using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Menu : MonoBehaviour {
	protected AudioListener sound;
	protected GameObject img;
	public static bool pause = false;
	
	void Start () {
				img = GameObject.Find ("Image");
				sound = GetComponent<AudioListener> ();

		}
public void MenuClick () {
		Application.LoadLevel("Menu");
		Debug.Log ("teste");
	}
public void rateClick () {
		string urlString = "market://details?id=" + "com.AF.StutheSpider";
		Application.OpenURL(urlString);
	}
public void	ReplayClick () {
		Application.LoadLevel("Jogo");
		Score.score = 0;
	}
public void	PlayClick () {
		Application.LoadLevel("Jogo");
		Score.score = 0;
		Time.timeScale = 1f;
	}
public void	PlacarClick () {
		Application.LoadLevel("Placar");
	}
public void InfoClick () {
		Application.LoadLevel ("Info");
	}
public void CreditosClick () {
		Application.LoadLevel ("Creditos");
	}
public void SoundClick () {
				if (AudioListener.volume == 1f) {
						AudioListener.volume = 0f;
						img.SetActive(false);
				} else {
						AudioListener.volume = 1f;
						img.SetActive(true);
				}
		}
public void PauseClick (){
				if (Time.timeScale == 1f) {
						Time.timeScale = 0f;
						pause = true;
						AudioCtrl.Toggle ();
						MenuPausa.Toggle ();
				} else {
						Time.timeScale = 1f;
						pause = false;
						AudioCtrl.Toggle ();
						MenuPausa.Toggle ();
				}
		}
}

