using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMovement : MonoBehaviour {
    Vector3 pos;
    Vector3 vel;
    Vector3 clickPos;
    Vector3 translatedClick;

    public Camera cam;

    float speedMult = 10f;
	// Use this for initialization
	void Start () {
        pos = this.transform.position;
        vel = new Vector3(-.1f, 0, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MouseMove();
	}
    void KeyMove(){
        //if (Input.GetKey(KeyCode.LeftArrow)){
        //pos += vel;
        //}
        //vel =
        vel = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //* speedMult;

        this.GetComponent<Rigidbody>().velocity = vel;

        //makes ball move around
        //pos = pos + vel;
        //this.transform.position = pos;

        //rigid body <-- physics engine add force, velocity
    }
    void MouseMove(){
        if(Input.GetMouseButton(0)){
           // Debug.Log("Click");
            Debug.Log("clickPos: " + clickPos);
            clickPos = Input.mousePosition;
            translatedClick = cam.ScreenToWorldPoint(new Vector3(clickPos.x, clickPos.y, cam.nearClipPlane));
            Debug.Log("translatedClick: " + translatedClick);
            Debug.DrawRay(Vector3.zero, translatedClick, Color.cyan);

            this.GetComponent<Rigidbody>().AddForce(new Vector3(translatedClick.x, translatedClick.y * speedMult, 0f));
        }
    }
}
