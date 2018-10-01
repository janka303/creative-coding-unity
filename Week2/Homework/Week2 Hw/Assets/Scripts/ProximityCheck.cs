using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityCheck : MonoBehaviour
{
    public GameObject Player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z >= Player.transform.position.z - 50f && this.transform.position.z <= Player.transform.position.z + 50f && this.transform.position.x >= Player.transform.position.x - 50f &&
            this.transform.position.x <= Player.transform.position.x + 50f)
        {

            Debug.Log("Entered Zone");
            this.GetComponent<Light>().enabled = true;

        }
        else
        {
            this.GetComponent<Light>().enabled = false;
        }
    }
}
