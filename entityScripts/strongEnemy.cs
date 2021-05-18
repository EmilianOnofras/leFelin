using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongEnemy : MonoBehaviour
{
    int direction = 1;
    int speedModifier = 1 ;
    Rigidbody enemyBody;

    void Start(){
        enemyBody = this.GetComponent<Rigidbody>();
    }

    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag=="obstacle"){
            direction *= -1;
        }
    }



    void FixedUpdate()
    {
        enemyBody.transform.Translate(-0.05f * speedModifier * direction,enemyBody.velocity.y,0);
        //enemyBody.velocity = new Vector3(enemySpeed * direction,enemyBody.velocity.y,0);
    }
}
