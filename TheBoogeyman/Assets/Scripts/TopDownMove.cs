using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{
    //Movement/Position variables
    public Rigidbody2D player;
    public float speed;
    public bool interact = false;
    public SpriteRenderer ply;

    public Animator PlayAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ply.flipX = false;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            PlayAnim.SetFloat("Down",1);

            PlayAnim.SetFloat("Up",0);
            PlayAnim.SetFloat("Side",0);
            PlayAnim.SetFloat("Idle",0);

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            PlayAnim.SetFloat("Side", 1);

            PlayAnim.SetFloat("Up", 0);
            PlayAnim.SetFloat("Down", 0);
            PlayAnim.SetFloat("Idle", 0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            PlayAnim.SetFloat("Side", 1);
            ply.flipX = true;

            PlayAnim.SetFloat("Up", 0);
            PlayAnim.SetFloat("Down", 0);
            PlayAnim.SetFloat("Idle", 0);
        }
        else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            PlayAnim.SetFloat("Up",1);

            PlayAnim.SetFloat("Down", 0);
            PlayAnim.SetFloat("Side", 0);
            PlayAnim.SetFloat("Idle", 0);
        }
        else
        {
            PlayAnim.SetFloat("Idle",1);

            PlayAnim.SetFloat("Up", 0);
            PlayAnim.SetFloat("Side", 0);
            PlayAnim.SetFloat("Down", 0);
        }
        
        //actually moves player
        player.velocity = new Vector2((Input.GetAxis("Horizontal")*speed)*Time.deltaTime, (Input.GetAxis("Vertical")*speed) * Time.deltaTime);
        if(Input.anyKey == false)
        {
            player.velocity = new Vector2(0 * Time.deltaTime, 0 * Time.deltaTime);
        }

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
