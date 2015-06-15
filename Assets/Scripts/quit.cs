using UnityEngine;
using System.Collections;
using UnionAssets.FLE;
public class quit : MonoBehaviour {
	protected string level;

	void Start (){

		level = Application.loadedLevelName;
		if (level == "Menu") {
						AndroidGoogleAnalytics.instance.StartTracking ();
						Invoke ("analytics", 1f);
				} else {
				}
		}
	private void analytics (){
				AndroidGoogleAnalytics.instance.SendView ("Home Screen");
				AndroidGoogleAnalytics.instance.EnableAdvertisingIdCollection(true);
		}

	void Update(){
		//if (Input.GetKeyDown(KeyCode.Escape)){ 
		//	if (level == "Menu"){
		//		AndroidAdMobController.instance.ShowInterstitialAd ();
		//		//Application.Quit();
		//	} if (level == "Creditos"){
		//		Application.LoadLevel("Info");
		//	} else {
		//		Application.LoadLevel("Menu");
		//	}
	//}
	}
}
