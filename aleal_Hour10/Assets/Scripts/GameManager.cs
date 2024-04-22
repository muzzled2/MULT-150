using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;

  
    private float startTime;
    private float finalTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (!isGameOver)
        {


            float elapsedTime = Time.time - startTime;
          
            isGameOver = blue.isSolved && green.isSolved && red.isSolved
                && orange.isSolved;
            if (isGameOver)
            {
                finalTime = elapsedTime;
            }

        }
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            ReplayGame();
        }
    }
    void OnGUI()

    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100,
               Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30,
                Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            Rect rect3 = new Rect(Screen.width / 2 - 80, Screen.height / 2 + 20, 160, 25);
            GUI.Label(rect3, "Final Time: " + FormatTime(finalTime));
            Rect rect4 = new Rect(Screen.width / 2 - 80, Screen.height / 2 + 45, 160, 25);
            GUI.Label(rect4, "Press 'R' to replay");
        }
       
    }
    
    void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    string FormatTime(float timeInSeconds)
    {
        string minutes = ((int)timeInSeconds / 60).ToString("00");
        string seconds = (timeInSeconds % 60).ToString("00");
        return minutes + ":" + seconds;
    }

}
