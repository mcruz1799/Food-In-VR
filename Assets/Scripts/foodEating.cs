using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodEating : MonoBehaviour
{

    // Use this for initialization
    private string[] foodTypes = { "sweet", "salty", "umami" };
    public bool check = false;
    
    private void OnTriggerEnter(Collider other)
    {
        AudioSource eating;
        //object food = other.gameObject;
        //check if its a food
        //bool check = false;
        foreach (string foodType in foodTypes)
        {
            print("Colliding with player this tag= " + this.gameObject.tag);
            if (other.gameObject.CompareTag(foodType)) check = true;
        }
        if (check)
        {
            other.gameObject.GetComponent<crumbs>().Crumbify();
            eating = this.gameObject.GetComponent<AudioSource>();
            eating.Play(0);
            //Destroy(other.gameObject);
        }

    }       
}
