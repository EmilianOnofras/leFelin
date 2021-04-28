using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTop : MonoBehaviour
{
    GameObject parentObject;
    void OnCollisionEnter(){

        Destroy(parentObject);
    }

    void Start(){
        parentObject = this.transform.parent.gameObject;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
