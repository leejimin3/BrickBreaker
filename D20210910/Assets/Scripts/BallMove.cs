using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallMove: MonoBehaviour

{

    private Rigidbody2D ballRd;         // Rigidbody 컴포넌트 저장

    public static float speed = 500.0f;        // 공의 속도

    Vector3 lastVelocity;



    // Start is called before the first frame update

    void Start()

    {

        ballRd = GetComponent<Rigidbody2D>();
        ballRd.AddForce(new Vector2(speed, speed * 0.7f));

    }



    // Update is called once per frame

    void Update()
    {
        lastVelocity = ballRd.velocity;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            Score.score += 1;
        }
        var speed = lastVelocity.magnitude;     // 공의 현재 속도

        var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        ballRd.velocity = dir * Mathf.Max(speed, 0f);

        GameObject.Find("GameSound").GetComponent<AudioSource>().Play();
    }

}

