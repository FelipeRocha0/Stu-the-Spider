using UnityEngine;
using System.Collections;

public class AudioCtrl : MonoBehaviour {
	protected static AudioSource AudioS;
	public static AudioClip gameover;
	public AudioClip gameoverr;
	void Start(){
		Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
		gameover = gameoverr;
				AudioS = GetComponent<AudioSource> ();
		}
	public static void Toggle () {
		if (Menu.pause == false)
		{
			AudioS.Play();
		}
		else
		{
			AudioS.Pause ();
		}
	}
	public static void StopSound () {
		AudioS.Pause ();
		AudioS.PlayOneShot (gameover, 0.8f);
		}
}