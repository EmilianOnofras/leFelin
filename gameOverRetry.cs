using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverRetry : MonoBehaviour
{
        public void retryGame(){
            SceneManager.LoadScene("firstLevel");
        }

}
