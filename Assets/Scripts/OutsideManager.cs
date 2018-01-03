using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col){
	
	if(col.gameObject.CompareTag("Collectable") || col.gameObject.CompareTag ("Enemy"))
			Destroy(col.gameObject);
	}

	/*
	void OnTriggerEnter2D(Collider2D col)
	{
		
		if(col.gameObject.CompareTag("Collectable"))
		{
			print("Collision detected with a trigger object");
			print(++score);
			Destroy(col.gameObject);
			//print(++score);
		}
	*/
}
