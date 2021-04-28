using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityTop : MonoBehaviour
{
    void OnCollisionEnter(){
        GameObject parentObject = this.transform.parent.gameObject;
        Destroy(parentObject);
    }
}
