using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	// Use this for initialization
	public float speed = 2.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 Vector2 offset = new Vector2 (Time.time * speed , 0);
		GetComponent<Renderer>().material.mainTextureOffset= offset;
	}
}
