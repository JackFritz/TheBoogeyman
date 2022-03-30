using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Togglescript : MonoBehaviour
{

    public DialogueRunner Dr;
    public Canvas canvas;
    public GameObject Player;

    public bool Talk;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Talk = true;
        Debug.Log("Enterd Tri");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Talk = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Talk == true)
        {
            //Dialog.SetActive(true);
            //canvas.enabled = true;
            Dr.StartDialogue("HelloYarn");
        }
        else
        {
            //Dialog.SetActive(false);
            //canvas.enabled = false;
        }

    }
}

