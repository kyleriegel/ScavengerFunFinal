using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour {

    public GameObject pausePanel;
    public Text endGame;

    public void PauseGame()  {
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }
    
    public void ResumeGame() {
        pausePanel.SetActive(false);
        Time.timeScale = 1;

    }


    void FixedUpdate()
    {
        GameObject timer = GameObject.Find("Timer");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        if (timerScript.currentTime <= 0 && !TimerScript.gameWon)
        {
            pausePanel.SetActive(true);          
            endGame = GameObject.Find("EndGame").GetComponent<Text>();
            endGame.text = "Try Again";
            Time.timeScale = 0;
        }
    }



} // class

