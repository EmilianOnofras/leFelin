using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public sessionData currentGame;
    public void playGame(){
        currentGame.defaultStart();
        SceneManager.LoadScene("firstLevel");
    }
}
