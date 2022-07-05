using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Right_Player")]
    public GameObject Right_Player_Paddle;
    public GameObject Right_Player_Goal;

    [Header("Left_Player")]
    public GameObject Left_Player_Paddle;
    public GameObject Left_Player_Goal;

    [Header("Score UI")]
    public GameObject Right_Player_Text;
    public GameObject Left_Player_Text;

    private int Right_Player_Score;
    private int Left_Player_Score;

    public void RPScored()
    {
        Right_Player_Score++;
        Right_Player_Text.GetComponent<TextMeshProUGUI>().text = Right_Player_Score.ToString();
        ResetPosition();
    }

    public void LPScored()
    {
        Left_Player_Score++;
        Left_Player_Text.GetComponent<TextMeshProUGUI>().text = Left_Player_Score.ToString();
        ResetPosition();
    }
    
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        Right_Player_Paddle.GetComponent<Paddle>().Reset();
        Left_Player_Goal.GetComponent<Paddle>().Reset();
    }
}
