using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float length, startpos;
    public float moveTarget; 
    public float parallaxEffect;
    public float temp;
    public float dist;

    void Start()
    {
        startpos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.y;

    }

    void FixedUpdate()
    {
        moveTarget -= parallaxEffect;
        temp = (moveTarget * (1 - parallaxEffect));
        dist = (moveTarget * parallaxEffect);

        transform.position = new Vector3(transform.position.x, startpos - dist, transform.position.z);

        if (temp > startpos + length)
        {
            startpos += length;
            Debug.Log("poo");
        }
        else if (temp/2.43 < startpos - length)
        {
            moveTarget = 0;
        }
    }
}
