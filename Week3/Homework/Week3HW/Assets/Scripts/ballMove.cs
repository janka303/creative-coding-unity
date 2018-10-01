using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour{
    public float speed;

    void Start(){
       
    }

    // Follows the target position like with a spring
    void Update(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal,0,vertical);

        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}