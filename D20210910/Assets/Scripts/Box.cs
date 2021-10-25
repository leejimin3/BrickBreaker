using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Ball")
        {
            Score.score += 1;
            GameObject.Find("GameSound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
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
