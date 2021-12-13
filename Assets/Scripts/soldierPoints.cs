using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierPoints : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "OldCar")
        {
            Debug.Log("hit the soldier");
            Scoreboard.totalScore += 1;
            Destroy(gameObject);
        }
    }

}