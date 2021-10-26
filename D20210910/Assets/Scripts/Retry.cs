using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void retry()
    {
        //GameObject.Find("Gameovertext").SetActive(true);
        //GameObject.Find("Cleartext").SetActive(true);
        SceneManager.LoadScene("SampleScene");
        Player.Control = true;
        
    }
}
