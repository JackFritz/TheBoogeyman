using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Transform Exit;
    public GameObject thePlayer;

    void OnCollisionEnter2D(Collision2D collision)
    {
        thePlayer.transform.position = Exit.transform.position;
    }
}
