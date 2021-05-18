using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpContainer : MonoBehaviour
{
    bool wasTriggered = false;
    public GameObject PowerUp;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Player" && !wasTriggered){
            Instantiate(PowerUp, new Vector3(this.transform.position.x
                                            ,this.transform.position.y +2
                                            ,this.transform.position.z), Quaternion.identity);
            wasTriggered = true;
        }
    }
}
