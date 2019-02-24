using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodDestroyer : MonoBehaviour {

	// Use this for initialization
	private string[] foodTypes = {"sweet", "salty", "umami"};
	private void OnCollisionEnter(Collision other) {

		//check if its a food
		bool check = false; 
		foreach(string foodType in foodTypes){
            print("this tag= " + this.gameObject.tag);
			if(other.gameObject.CompareTag(foodType)) check = true;
		}
		if(check) Destroy(other.gameObject);
        check = false;
	}
}
