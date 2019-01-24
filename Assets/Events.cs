using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour {

	public Text text;
	private void OnTriggerEnter(Collider other){
		text.enabled = true;
		
		
	}
	
	private void OnTriggerExit(Collider other){
		text.enabled = false;
	}
}
