using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{
    //Movement/Position variables
    public Rigidbody2D player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //actually moves player
        player.velocity = new Vector2(Input.GetAxis("Horizontal")*3, Input.GetAxis("Vertical")*3);
        
    }
}
