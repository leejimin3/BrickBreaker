using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    private Rigidbody2D ballRd;
    public static float Ballspeed = 500.0f;
    public static bool timeflag = false;
    // Start is called before the first frame update
    public void Moveball()
    { 
        ballRd = GameObject.Find("Ball").GetComponent<Rigidbody2D>();

        //ballRd.AddForce(new Vector2(speed, speed * 0.7f));
        Vector2 ran = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f) ).normalized;
        //ballRd.velocity = transform.forward * speed;
        ballRd.AddForce(ran*Ballspeed);
        ran = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        timeflag = true;
        Destroy(gameObject);
    }

}
