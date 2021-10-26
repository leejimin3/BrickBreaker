using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public static int boxc = 54;
    public GameObject Gameover;
    public GameObject FinalScore;
    void OnCollisionEnter2D(Collision2D coll)
    {
        Text ScoreText;
        ScoreText = FinalScore.GetComponent<Text>();

        if (coll.gameObject.name == "Ball")
        {
            boxc -= 1;
            Score.score += 1;
            GameObject.Find("GameSound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Debug.Log(boxc);
            if(boxc  == 0)
            {
                ScoreText.text = "당신의 점수 : " + Score.score;
                Player.Control = false;
                StartPanel.timeflag = false;
                Gameover.SetActive(true);
                Destroy(GameObject.Find("Gameovertext"));
                Player.Ballcount = 1;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
