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
    private SpriteRenderer Poo;

    public Sprite No;
    public Sprite Yes;
    // Start is called before the first frame update
    void Start()
    {
        Dr.Stop();
        Talk = false;
        Poo = Attention.GetComponent<SpriteRenderer>();
        Poo.sprite = No;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Talk = true;
        }
        
        
        Poo.sprite = Yes;

        if (CompareTag("Lucas")&& Talk == true)
        {
            
            Dr.StartDialogue("Start");
            Talk = false;
             
        }
        else if (CompareTag("Gravestone") && Talk == true)
        {
            Dr.StartDialogue("Gravestone");
            
        }
        else if (CompareTag("Storefront") && Talk == true)
        {
            Dr.StartDialogue("Storefront");

        }
        else if (CompareTag("TV") && Talk == true)
        {
            Dr.StartDialogue("TV");

        }
        else if (CompareTag("Mirror") && Talk == true)
        {
            Dr.StartDialogue("Mirror");

        }
        else if (CompareTag("Couch") && Talk == true)
        {
            Dr.StartDialogue("Couch");

        }
        else if (CompareTag("Refrigerator") && Talk == true)
        {
            Dr.StartDialogue("Refrigerator");

        }
        else if (CompareTag("KitchenTable") && Talk == true)
        {
            Dr.StartDialogue("KitchenTable");

        }
        else if (CompareTag("PalmTree") && Talk == true)
        {
            Dr.StartDialogue("PalmTree");

        }
        else if (CompareTag("KitchenTrash") && Talk == true)
        {
            Dr.StartDialogue("KitchenTrash");

        }
        else if (CompareTag("PicOfElizabeth") && Talk == true)
        {
            Dr.StartDialogue("PicOfElizabeth");

        }
        else if (CompareTag("WantedPoster") && Talk == true)
        {
            Dr.StartDialogue("WantedPoster");

        }

    }

    public void Done()
    {
        Talk = false;
        Dr.Stop();
        Poo.sprite = No;
        
    }

    void OnTriggerExit2D(Collider2D collision)
    { 
         Talk = false;
         Poo.sprite = No;
         Dr.Stop();
         
               
    }

    // Update is called once per frame
    void Update()
    {
       if(Talk== false)
        {
            Dr.Stop();
            
        }
        
    }
}

