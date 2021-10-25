using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextTimer : MonoBehaviour
{
    public Text timerTxt;
    public float time = 100f;
    private float selectCountdown;
    // Start is called before the first frame update
    void Start()
    {
        timerTxt = GetComponent<Text>();
        selectCountdown = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Floor(selectCountdown) > 0 && StartPanel.timeflag == true)
        {
            selectCountdown -= Time.deltaTime;
            timerTxt.text = "Time : " + Mathf.Floor(selectCountdown).ToString();
        }
    }
}
