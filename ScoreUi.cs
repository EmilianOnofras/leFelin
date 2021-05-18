using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    public Text livesCount,coinsCount,pointsCount,timeCount;
    int livesCounter,coinsCounter,pointsCounter,timeCounter=700;

    void Start(){
        //InvokeRepeating("decreaseTime",1f,1f);
    }

    void decreaseTime(bool gameStaus){
        if(timeCounter>0){
            timeCounter -=7;
        }else{

        }    
    }

    public void convertTimeToPoints(){ // invoke repeating that decreases time and ads points till 0

    }

    public void updateCoins(int newValue){
        coinsCount.text = newValue.ToString();
    }

    public void updatePoints(int newValue){
        pointsCount.text = newValue.ToString();
    }

    public void updateLives(int newValue){
        livesCount.text = newValue.ToString();
    }
}
