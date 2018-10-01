using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour {

    Color start = Color.green;
    Color end = Color.blue;

    Renderer r;

	// Use this for initialization
	void Start () {
        r = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float lerper = Mathf.Abs(Mathf.Sin(Time.time));
        r.material.color = Color.Lerp(start, end, lerper);
	}
}
