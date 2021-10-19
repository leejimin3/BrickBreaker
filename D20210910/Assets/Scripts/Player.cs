using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 speed_vec;
    public static bool Control = true;
    Vector2 move = new Vector2(6.4f, 0);
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Move(transform.localPosition);
        if (Control == true)
        {
            speed_vec = Vector2.zero;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                speed_vec.x += 0.05f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed_vec.x -= 0.05f;
            }
            transform.Translate(speed_vec);
        }

    }

    public Vector3 Move(Vector3 position)
    {
        return new Vector3(Mathf.Clamp(position.x, -move.x,move.x),-4.2f,0);
    }
}
