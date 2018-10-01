using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLerp : MonoBehaviour {

    Vector3 start;
    Vector3 end;
    float lerpVal;

    Vector3 pos;

    // Use this for initialization
    void Start() {
        start = new Vector3(-5f, -2f, -6f);
        end = new Vector3(4f, 7f, 3f);
    }

    // Update is called once per frame
    void Update() {
        lerpVal = Mathf.Abs(Mathf.Sin(Time.time));
        pos = Vector3.SlerpUnclamped(start, end, lerpVal);

        transform.position = pos;

        if(lerpVal <0.01f){
            Debug.Log("Hello?");
            end = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            Debug.Log(end);
        }
    }
}
