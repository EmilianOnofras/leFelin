using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sessionData : MonoBehaviour
{
    int numberOfLives;
    void Awake(){
    DontDestroyOnLoad(this.gameObject);
    }

    public void defaultStart(){
        numberOfLives=3;
    }

    public void lostBattle(){
        numberOfLives-=1;

        if(numberOfLives == 0){
            SceneManager.LoadScene("gameOver");
        }

        SceneManager.LoadScene("firstLevel");
    }


    public int liveCount(){
        return numberOfLives;
    }

}
