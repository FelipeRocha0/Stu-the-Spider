using UnityEngine;
using System.Collections;

public class Adscontrol : MonoBehaviour {
	string level;
	private const string MY_BANNERS_AD_UNIT_ID		 = "ca-app-pub-7208620975604817/2952582085"; 
	private const string MY_INTERSTISIALS_AD_UNIT_ID =  "ca-app-pub-7208620975604817/5906048482";
	GoogleMobileAdBanner banner;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);
		AndroidAdMobController.instance.Init(MY_BANNERS_AD_UNIT_ID);
		AndroidAdMobController.instance.SetInterstisialsUnitID(MY_INTERSTISIALS_AD_UNIT_ID);
		AndroidAdMobController.instance.AddKeyword("Game");
		AndroidAdMobController.instance.SetBirthday(2002, AndroidMonth.MARCH, 18);
		Invoke ("ads", 1);
		AndroidAdMobController.instance.OnInterstitialLoaded += OnInterstisialsLoaded;
		AndroidAdMobController.instance.OnInterstitialOpened += OnInterstisialsOpen;
		AndroidAdMobController.instance.OnInterstitialClosed += OnInterstisialsClosed;
		
		//loadin ad:
		AndroidAdMobController.instance.LoadInterstitialAd ();

	}
	
	void ads(){
		banner = AndroidAdMobController.instance.CreateAdBanner (TextAnchor.UpperCenter, GADBannerSize.SMART_BANNER);
		banner.Show ();
	}
	void Update (){
		level = Application.loadedLevelName;
		if (Input.GetKeyDown(KeyCode.Escape)){ 
			if (level == "Menu"){
				AndroidAdMobController.instance.ShowInterstitialAd ();
				//Application.Quit();
			} if (level == "Creditos"){
				Application.LoadLevel("Info");
			} else {
				Application.LoadLevel("Menu");
			}
		}


		if (level == "Creditos"){
			banner.Hide ();}
		if (level == "Info"){
			banner.Hide ();}
		if (level == "Placar"){
			banner.Hide ();}
		if (level == "GameOver"){
			banner.Show ();}
		if (level == "Menu"){
			banner.Show ();}
		if (level == "Jogo"){
			banner.SetBannerPosition (TextAnchor.LowerCenter);
			if (Time.timeScale == 1f){
				banner.Hide ();
			} else { banner.Show ();
			}
		} else { banner.SetBannerPosition(TextAnchor.UpperCenter);
		}
	}
	private void OnInterstisialsLoaded() {
	}
	
	private void OnInterstisialsOpen() {
		//pausing the game
	}
	private void OnInterstisialsClosed() {
		Application.Quit ();
	}
	//private void OnInterstisialsOpen() {
		//Time.timeScale = 0f;
	//}
	//void close (){
	//			Application.Quit ();
		//}
}
