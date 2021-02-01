using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 12f;
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
   void Update()
    {
       if (timer >= 0f)
        {
          timer -= Time.deltaTime;
          timerText.text = "Timer: " + Mathf.Round(timer);
        }
    }

}
