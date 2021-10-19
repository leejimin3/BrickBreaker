using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject Ball;
    public GameObject FinalScore;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Text ScoreText;
        ScoreText = FinalScore.GetComponent<Text>();

        if (collision.gameObject.name == "Down")
        {
            ScoreText.text = "당신의 점수 : " + Score.score;
            Player.Control = false;
            Gameover.SetActive(true);
            Destroy(Ball);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
