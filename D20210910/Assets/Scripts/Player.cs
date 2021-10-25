using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D a;
    public GameObject ball;
    //public Vector2 speed_vec;
    public static bool Control = true;
    public static int Ballcount = 1;
    Vector2 move = new Vector2(6.4f, 0);
    int speed = 20;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Move(transform.localPosition);
        if (Control == true && StartPanel.timeflag == true)
        {
            float Move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Move = speed * Time.deltaTime;
                //speed_vec.x += 0.05f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Move = -speed * Time.deltaTime;
                // speed_vec.x -= 0.05f;
            }
            this.transform.Translate(new Vector2(Move, 0));
            //transform.Translate(speed_vec);
        }
    }
    public void Ins()
    {
        GameObject secball = GameObject.Find("Ball");
        GameObject new1 = Instantiate(secball, secball.transform.position, secball.transform.rotation);
        //GameObject new1 = Instantiate(GameObject.Find("Ball"), ball.transform.position, ball.transform.rotation);

        Ballcount +=1;
        new1.name = "Ball";
        Vector2 ran = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f)).normalized;
        new1.GetComponent<Rigidbody2D>().AddForce(ran * StartPanel.Ballspeed);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Ins();
        }
    }

    public Vector3 Move(Vector3 position)
    {
        return new Vector3(Mathf.Clamp(position.x, -move.x,move.x),-4.2f,0);
    }
}
