using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool IsRPGoal;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!IsRPGoal)
            {
                GameObject.Find("GameManager").GetComponent<Game_Manager>().RPScored();
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<Game_Manager>().LPScored();
            }
        }
    }
}
