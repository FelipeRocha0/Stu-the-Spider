using UnityEngine;
using System.Collections;

public class som : MonoBehaviour {
	protected string level;
	void Awake () {
				DontDestroyOnLoad (gameObject);
		}

void Update(){
	level = Application.loadedLevelName;
	if (level == "Jogo") {
		Destroy(this.gameObject);}
}
}
