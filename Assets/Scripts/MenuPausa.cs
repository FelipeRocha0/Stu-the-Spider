using UnityEngine;
using System.Collections;

public class MenuPausa : MonoBehaviour {
	protected static GameObject objct;
	protected static GameObject objct2;
	void Start () {
		objct = (GameObject.Find("Panel"));
		objct2 = (GameObject.Find("Panel2"));
		if (gameObject.name == "Panel") {
					gameObject.SetActive (false);
				} else {
						gameObject.SetActive (true);
				}
		}
public static void Toggle () {
		if (Menu.pause == false)
		{
			objct.SetActive(false);
			objct2.SetActive(true);
		}
		else
		{
			objct.SetActive(true);
			objct2.SetActive(false);
		}
	}
}
