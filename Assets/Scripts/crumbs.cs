using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumbs : MonoBehaviour {

	Collider collider;
	Rigidbody rigidbody;
    [SerializeField] GameObject crumb;
    public bool isCurrent = false;

	void Awake() { 
		collider = GetComponent<Collider>();  
		rigidbody = GetComponent<Rigidbody>();
    }

	void Start() { }

	void Update() {
        //if (foodEating.check == true) { Instantiate(crumb, transform.position, transform.rotation); }
    }

	public void Crumbify() {

        Instantiate(crumb, transform.position, transform.rotation);
        print("Crumbify");
        gameObject.SetActive(false);
        Destroy(gameObject);
    } 
}
