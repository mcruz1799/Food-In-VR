using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateWorld : MonoBehaviour {
	public Material Sweet;
	public GameObject Poster1;
	public Material Salty;
	public Material Umami;
	public string foodType;
	private string world;
	private void Awake() {
		world = foodType;
		Debug.Log("world = " + world);
		foreach(GameObject obj in Resources.FindObjectsOfTypeAll(typeof(GameObject))){
            //obj.SetActive(true);
            if (obj.CompareTag(world)) obj.SetActive(true);
            //else obj.SetActive(true);
		}
		Poster1.GetComponent<Renderer>().material = Sweet;
	}
}
