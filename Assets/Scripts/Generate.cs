using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	// Use this for initialization
	public float CollectabeInterval, EnemyInterval;
	public GameObject collectables, Enemy;
	void Start () {
		InvokeRepeating ( "GenerateCollectablle" , 2.0f , CollectabeInterval);
		InvokeRepeating ( "GenerateEnemy" , 5.0f , EnemyInterval);
	}
	
	// Update is called once per frame
	void GenerateCollectablle () {

		Instantiate(collectables);
	}

	void GenerateEnemy(){
		Instantiate(Enemy);
	}
}
