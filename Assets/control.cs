using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	public float mSpeed = 0.5f;
	Vector3 mVelocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	mVelocity = Vector3.zero;
	if(Input.GetKey(KeyCode.W)){
		transform.Translate(0.0f,0.0f, mSpeed*Time.deltaTime);
	}else if(Input.GetKey(KeyCode.S)){
		transform.Translate(0.0f, 0.0f,-mSpeed*Time.deltaTime);
	}
	
	if(Input.GetKey(KeyCode.D)){
		transform.Translate(mSpeed*Time.deltaTime,0.0f,0.0f);
	}else if(Input.GetKey(KeyCode.A)){
		transform.Translate(-mSpeed*Time.deltaTime,0.0f,0.0f);
		
	}
	if(Input.GetKey(KeyCode.E)){
		transform.Rotate(0.0f,20*Time.deltaTime,0.0f);
		
		
	}
	else if(Input.GetKey(KeyCode.Q)){
		transform.Rotate(0.0f,-20*Time.deltaTime,0.0f);
	}
	
	}
}
