using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawner : MonoBehaviour {
	public GameObject food;
	private Vector3 initialP;
	private Quaternion initialR;
	public int spawnDelay;
	private bool pickedUp;
	private float pickUpTime;
	private string[] foodTypes = {"sweet", "salty", "umami"};
	// Use this for initialization
	void Start () {
		//food = this.gameObject;
		
		pickedUp = false;
		spawnDelay = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (pickedUp && (Time.time - pickUpTime > spawnDelay)){
			spawnNew();
			pickedUp = false;
		}

	}
	void OnCollisionExit(Collision other) {
		print("Triggered");
		print(other.gameObject.tag);
		foreach(string foodType in foodTypes){
			if (other.gameObject.CompareTag(foodType)){
				pickedUp = true;
				pickUpTime = Time.time;
				initialP = other.transform.position;
				initialR = this.transform.rotation;
				print("Spawn");
				//spawnNew();
			}
		}
	}
	void spawnNew(){
        print("Ins");
		Instantiate(food,initialP,initialR);
	}
}
