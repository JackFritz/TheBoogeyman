using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.EventSystems;
using UnityEngine.Events;

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
        Dr.Stop();
        Talk = false;
        Attention.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Talk = true;
        }
        else { Talk = false; }

        if (CompareTag("Lucas")){ 

            Attention.SetActive(true);

          if(Talk == true)
            {
                Dr.StartDialogue("Start");
            }
           
        }
        if (CompareTag("Gravestone") && Talk == true)
        {
            Dr.StartDialogue("Gravestone");
            
        }
        if (CompareTag("Storefront") && Talk == true)
        {
            Dr.StartDialogue("Storefront");

        }
        if (CompareTag("TV") && Talk == true)
        {
            Dr.StartDialogue("TV");

        }
        if (CompareTag("Mirror") && Talk == true)
        {
            Dr.StartDialogue("Mirror");

        }
        if (CompareTag("Couch") && Talk == true)
        {
            Dr.StartDialogue("Couch");

        }
        if (CompareTag("Refrigerator") && Talk == true)
        {
            Dr.StartDialogue("Refrigerator");

        }
        if (CompareTag("KitchenTable") && Talk == true)
        {
            Dr.StartDialogue("KitchenTable");

        }
        if (CompareTag("PalmTree") && Talk == true)
        {
            Dr.StartDialogue("PalmTree");

        }
        if (CompareTag("KitchenTrash") && Talk == true)
        {
            Dr.StartDialogue("KitchenTrash");

        }
        if (CompareTag("PicOfElizabeth") && Talk == true)
        {
            Dr.StartDialogue("PicOfElizabeth");

        }
        if (CompareTag("WantedPoster") && Talk == true)
        {
            Dr.StartDialogue("WantedPoster");

        }

    }

    public void Done()
    {
        Talk = false;
        Dr.Stop();
        
    }

    void OnTriggerExit2D(Collider2D collision)
    { 
        Talk = false;
        Attention.SetActive(false);
        Dr.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

