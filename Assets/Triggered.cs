using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggered : MonoBehaviour {

	public Text text;
	private void OnTriggerEnter(Collider other){
		text.text = "ENTERED";
		Debug.Log("ENTERED THE ZONE");
		
		
	}
	
	private void OnTriggerExit(Collider other){
		
		text.text = "LEFT";
		Debug.Log("LEFT THE ZONE");
	}
}
