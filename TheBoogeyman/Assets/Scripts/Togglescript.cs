using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Togglescript : MonoBehaviour
{

    public DialogueRunner Dr;
    public Canvas canvas;
    public GameObject Player;

    
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        Dr.Stop();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("Lucas"))
        {
            canvas.enabled = true;
            Dr.StartDialogue("Start");
        }
        else if (CompareTag("Finish"))
        {
            canvas.enabled = true;
            Dr.StartDialogue("Node");
        }


    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canvas.enabled = false;
        Dr.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

