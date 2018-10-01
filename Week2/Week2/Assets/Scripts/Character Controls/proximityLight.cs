using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityLight : MonoBehaviour {
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(this.transform.position.z >= Player.transform.position.z - 1f && this.transform.position.z <= Player.transform.position.z + 1f){
         
            Debug.Log("Entered Zone");
            this.GetComponent<Light>().enabled = true;

        }
        else{
            this.GetComponent<Light>().enabled = false;
        } 	
	}
}
