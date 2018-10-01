using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiLerp : MonoBehaviour {

    Vector3 p1, p2, p3;

    // Use this for initialization
	void Start () {
        p1 = new Vector3(-1f, -1f, -1f);
        p2 = new Vector3(0f, 0f, 0f);
        p3 = new Vector3(-1f, -1f, -1f);
		
	}
	
	// Update is called once per frame
	void Update () {
        float lerpVal = Mathf.Sin(Time.time);
        if(lerpVal <= 0){
            float val = map(lerpVal, -1f, 0f, 0f, 1f);
            transform.position = Vector3.Lerp(p1, p2, val);
        }else{
            transform.position = Vector3.Lerp(p2, p3, lerpVal);
        }
	}
    
    float map(float v, float i1, float i2, float o1, float o2){
        return o1 + (v - i1) * (o2 - 01) / (i2 - i1);
    }
}
