using UnityEngine;
using System.Collections;

public class MenuSom : MonoBehaviour {
	public GameObject Som;

	void Awake () {
	if (!GameObject.Find("Som(Clone)")){
			Instantiate (Som);
		} else {}

	}

	}
