using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiePointsPoCar : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision .transform .name == "PoliceCar")
        {
            Debug.Log("hit the zombie");
            Scoreboard.totalScore -= 1;
            Destroy(gameObject);
        }
    }

}
