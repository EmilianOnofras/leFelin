using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{

    GameObject playerRefrence;

    int nrPoints, nrCoins, nrLives,playerPowerLvl;

    GameObject currentRun;

    // Start is called before the first frame update
    void Start()
    {
        playerRefrence = GameObject.Find("Player");
        nrPoints = 0;
        nrCoins = 0;
        playerPowerLvl=1;
        currentRun = GameObject.Find("sessionData");
        Debug.Log(currentRun.GetComponent<sessionData>().liveCount());
    }

    public void lifeLost(){
        if(playerPowerLvl>1){
            playerPowerLvl-=1;
            playerRefrence.GetComponent<playerScript>().invulnerable();
        }else{
            currentRun.GetComponent<sessionData>().lostBattle();
        }
    }

    public void powerUp(){
        playerPowerLvl+=1;
        Debug.Log("powerUp");
    }

}
