using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{

    GameObject playerRefrence;

    int nrPoints, nrCoins, nrLives,playerPowerLvl;

    GameObject currentRun;

    public ScoreUi uiController;

    // Start is called before the first frame update
    void Start()
    {
        playerRefrence = GameObject.Find("Player");
        nrPoints = 0;
        nrCoins = 0;
        playerPowerLvl=1;
        currentRun = GameObject.Find("sessionData");
        //Debug.Log(currentRun.GetComponent<sessionData>().liveCount());

        uiController.updateLives(currentRun.GetComponent<sessionData>().liveCount());
    }

    public void lifeLost(){
        if(playerPowerLvl>1){
            playerPowerLvl-=1;
            playerRefrence.GetComponent<playerScript>().invulnerable();
            playerRepresentation(0);
        }else{
            currentRun.GetComponent<sessionData>().lostBattle();
        }
    }

    public void fallLose(){
        currentRun.GetComponent<sessionData>().lostBattle();
    }

    public void powerUp(){
        playerPowerLvl+=1;
        playerRepresentation(1);
    }

    void playerRepresentation(int alteration){
        switch(alteration)
        {
            case 0:
                playerRefrence.GetComponent<Renderer>().material.SetColor("_Color",new Color(142f/255f, 37f/255f, 40f/255f));
                break;
            case 1:
                playerRefrence.GetComponent<Renderer>().material.SetColor("_Color",Color.cyan);
                break;
            case 2:
                playerRefrence.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
                break;
            default:
                break;
        }
    }

}
