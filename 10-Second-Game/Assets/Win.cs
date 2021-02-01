using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public bool isWin = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void winGame()
    {
        Debug.Log("I QUIT!");
        Application.Quit();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.Find("Timer").GetComponent<Timer>().isLose == false)
        {
         Debug.Log("I'm Triggered!");
         isWin = true;
        Invoke("winGame", 3);
        }
    }
}
