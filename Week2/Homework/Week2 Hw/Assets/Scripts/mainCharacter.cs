using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharacter : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 pos;
    // Use this for initialization
    void Start()
    {
        pos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed;
        }
        this.transform.position = pos;

    }
}
