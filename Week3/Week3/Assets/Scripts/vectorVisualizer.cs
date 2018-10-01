using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorVisualizer : MonoBehaviour {
    Vector3 vecA;
    Vector3 vecB;
    float mag;
    Vector3 normalA;
    void Start() {

        vecA = new Vector3(3, 6, 9); //x,y,z
        vecB = new Vector3(-2, 2, 8);
    }

    // Update is called once per frame
    void Update() {
        DrawTransformVectors();
    }

    void DrawVectorMath() {
        Debug.DrawRay(Vector3.zero, vecA, Color.blue);//takes in vector start //magnitude = sqrt(x^2 + y^2 + z^2)
        Debug.DrawRay(Vector3.zero, vecB, Color.red);
        mag = Mathf.Sqrt(vecA.x * vecA.x + vecA.y * vecA.y + vecA.z * vecA.z); //Mathf.Pow(vecA.x, 2f);  <- another way to do it

        Debug.Log("mag: " + mag); //debug.log = print
        Debug.Log("this is Unity mag: " + vecA.magnitude);

        //normal vector = your vector/ mag

        normalA = (vecA / mag);
        Debug.Log("normal: " + normalA);
        Debug.Log("Unity built in normal: " + vecA.normalized);
        Debug.DrawRay(Vector3.zero, normalA, Color.green);
        //Debug.DrawRay(Vector3.zero, normalA * 20f);

        //Addition
        Debug.DrawRay(Vector3.zero, vecA + vecB, Color.gray);

        //Subtraction
        Vector3 AMinusB = vecA - vecB;
        Vector3 BMinusA = vecB - vecA;

        Debug.DrawRay(vecA, BMinusA, Color.yellow);
        Debug.DrawRay(vecB, AMinusB, Color.magenta);
    }

    void DrawTransformVectors()
    {
        Debug.DrawRay(transform.position, transform.right, Color.green);
        Debug.DrawRay(transform.position, transform.up, Color.red);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
         
    }
}
