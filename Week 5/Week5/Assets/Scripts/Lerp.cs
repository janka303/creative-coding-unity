using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour {
    //start, end, lerp value
    public float speed = 10;
    public float distance = 10;

    float timer = 0;
    public float maxtime = 2;

	// Use this for initialization
	void Start () {
        //Debug.Log(Mathf.Lerp(0, 1, 0));
        //Time.time = constantly counting up from moment game start
        //Time.deltaTime = difference between frames
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(new Vector3(0, 0, 1)*Time.deltaTime); //actual speed of one
        //transform.Translate(new Vector3(0, 0, Mathf.Sin(Time.time))); //moves back and forth
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(Time.time*distance)*speed); //move back and forth slower, if you *10 = further, time.time* speed = faster

        timer += Time.deltaTime;
        if (timer >= maxtime){
            transform.Translate(new Vector3(0, 0, 1));
            timer = 0;
        }
    }
}
