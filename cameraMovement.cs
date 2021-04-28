using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    private Vector2 velocity;
    GameObject playerCurrent;
    float smoothTimeX= 0.05f;
    float newPositionOnXAxis = 0f;

    float currentFarthesPosition=0;

    
    void Start()
    {
        playerCurrent = GameObject.Find("Player");
        currentFarthesPosition = playerCurrent.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerCurrent.transform.position.x >= currentFarthesPosition){
            currentFarthesPosition = playerCurrent.transform.position.x;
            newPositionOnXAxis = Mathf.SmoothDamp(transform.position.x, playerCurrent.transform.position.x,ref velocity.x,smoothTimeX);
            transform.position = new Vector3(newPositionOnXAxis,transform.position.y,transform.position.z);
        }
    }
}
