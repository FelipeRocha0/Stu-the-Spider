using UnityEngine;
using System.Collections;
using UnionAssets.FLE;
using UnityEngine.UI;

public class Share : MonoBehaviour {
	int scoreshare = Score.score;
	public bool IsAuntificated;
	string msg;
	void Awake (){
		msg = scoreshare + " pontos em Stubborn Spider!";
			SPFacebook.instance.Init ();
			SPFacebook.instance.OnInitCompleteAction += OnInit;
			SPFacebook.instance.OnFocusChangedAction += OnFocusChanged;
	}
	private void OnInit() {
		if(SPFacebook.instance.IsLoggedIn) {
			//OnAuth();
		} else {
			SA_StatusBar.text = "user Login -> fale";
		}
	}
	private void OnAuth(FBResult result) {
		if(SPFacebook.instance.IsLoggedIn) {
			IsAuntificated = true;
			SA_StatusBar.text = "user Login -> true";
		} else {
		}
	}
	
	private void OnFocusChanged(bool focus) {
		if (!focus)  {                                                                                  
			// pause the game - we will need to hide                                             
			Time.timeScale = 0;                                                                  
		} else  {                                                                                       
			// start the game back up - we're getting focus again                                
			Time.timeScale = 1;                                                                  
		}   
	}
	public void	ShareClick () {
		//SPFacebook.instance.Login ("publish_actions");
		SPFacebook.instance.PostWithAuthCheck (
			link: "https://play.google.com/store/apps/details?id=com.AF.StutheSpider",
			linkName: "Stu the Spider",
			linkCaption: "Venha conferir meu placar!",
			linkDescription: "Acabei de fazer " + msg,
			picture: "http://bit.ly/AFStutheSpider"
			);
	}}
