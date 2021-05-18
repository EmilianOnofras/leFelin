using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    Rigidbody powerUpBody;
    void Start(){
        powerUpBody = this.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Player"){
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        powerUpBody.transform.Translate(0.05f,0,0);
    }
  
    
}
