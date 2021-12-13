using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePoCar : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision .transform .name == "PoliceCar")
        {
            Debug.Log("End Game");
            SceneManager.LoadScene("Survived");
        }
    }

}