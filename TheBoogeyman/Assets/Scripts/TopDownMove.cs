using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{
    //Movement/Position variables
    public Rigidbody2D player;
    public float speed;
    public bool interact = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //actually moves player
        player.velocity = new Vector2((Input.GetAxis("Horizontal")*speed), (Input.GetAxis("Vertical")*speed));

        if (Input.GetKeyDown(KeyCode.E))
        {
            interact = true;
        }
        else
        {
            interact = false;
        }
    }
}
