using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject FinalScore;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Text ScoreText;
        ScoreText = FinalScore.GetComponent<Text>();

        if (collision.gameObject.name == "Down")
        {
            Destroy(gameObject);
            Player.Ballcount-=1;
            if (Player.Ballcount == 0)
            {
                ScoreText.text = "당신의 점수 : " + Score.score;
                Player.Control = false;
                StartPanel.timeflag = false;
                Gameover.SetActive(true);
                Destroy(GameObject.Find("Cleartext"));
                Player.Ballcount = 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
