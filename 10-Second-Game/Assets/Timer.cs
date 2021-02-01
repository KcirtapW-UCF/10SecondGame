using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timer = 12f;
    Text timerText;
    public bool isLose = false;
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
   void Update()
    {
        if (GameObject.Find("Finish").GetComponent<Win>().isWin == false)
        {
            if (timer >= 0f)
            {
             timer -= Time.deltaTime;
             timerText.text = "Timer: " + Mathf.Round(timer);
            }
            else 
            {
               timerText.text = "YOU LOSE";
               isLose = true;
                Invoke("loseGame", 3);
            }
        }
    }
    void loseGame()
    {
         SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

}
