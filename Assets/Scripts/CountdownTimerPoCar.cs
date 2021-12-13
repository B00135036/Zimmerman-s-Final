using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimerPoCar : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 90f;
    [SerializeField] Text countdownText;

 
    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}