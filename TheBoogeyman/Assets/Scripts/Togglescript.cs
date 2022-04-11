using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Togglescript : MonoBehaviour
{

    public DialogueRunner Dr;
    public Canvas canvas;
    public GameObject Player;
    private bool Talk;
    public GameObject Attention;
    
    // Start is called before the first frame update
    void Start()
    {
        //canvas.enabled = false;
        Dr.Stop();
        Talk = false;
        Attention.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Attention.SetActive(true);

        if (Input.GetKey(KeyCode.E))
        {
            Talk = true;
        }
        if (CompareTag("Lucas") && Talk == true)
        {
            //canvas.enabled = true;
            Dr.StartDialogue("Start");
        }
       
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //canvas.enabled = false;
        Dr.Stop();
        Talk = false;
        Attention.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

