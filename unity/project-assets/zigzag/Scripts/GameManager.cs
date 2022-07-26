using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool gameStarted;


    public void StartGame(){
        gameStarted = true;
       
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            StartGame();
        }
    }

}
