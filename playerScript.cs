using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerScript : MonoBehaviour
{
    Rigidbody playerBody;
    bool enemyCollisionLogic = true;
    public gameMaster gmMaster;
    public int playerSpeed = 2000;
    public double playerDirection=0;

    public void Jump(InputAction.CallbackContext context){
        if(context.performed && transform.position.y==1){
            playerBody.AddForce(0,12000,0);
        }
    }

    public void hopUp(){
        playerBody.AddForce(0,4000,0);
    }

    void Awake(){
        playerBody = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        switch(playerDirection){
            case(1):
                playerBody.AddForce(Time.deltaTime * playerSpeed,0,0);
                break;
            case(-1):
                playerBody.AddForce(Time.deltaTime * -playerSpeed,0,0);
                break;
            default:
                break;
        }
            
        
    }

    void OnCollisionEnter(Collision collisionInfo){
        switch(collisionInfo.collider.tag){
            case("entity"):
                playerBody.AddForce(0,6000,0);
                break;
            case("box"):
                playerBody.AddForce(0,-4000,0);
                break;
            case("powerUp"):
                gmMaster.powerUp();
                break;
            case("enemy"):
                if(enemyCollisionLogic){
                    gmMaster.lifeLost();
                }
                break;
        }
    }

    public void movePlayer(InputAction.CallbackContext context){
        playerDirection = context.ReadValue<float>();
    }

    public void invulnerable(){
        playerBody.gameObject.layer = 10;
        enemyCollisionLogic=false;
        InvokeRepeating("blink", 1f, 0.4f);
        Invoke("vulnerable",4);
    }

    void vulnerable(){
        playerBody.gameObject.layer = 7;
        enemyCollisionLogic=true;
        CancelInvoke();
        this.GetComponent<Renderer>().enabled = true;
    }

    void blink(){
        this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
    }

}






