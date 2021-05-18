using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityTop : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Player"){
            GameObject parentObject = this.transform.parent.gameObject;
            Destroy(parentObject);
        }
    }
}
