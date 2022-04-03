using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Togglescript : MonoBehaviour
{

    public GameObject Dialog;
    public GameObject Player;

    public bool Talk;
    void OnPreCull()
    {
        //Dialog.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        //Dialog.SetActive(false);

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
        if (Input.GetKey(KeyCode.E))
        {
            Talk = true;
        }
        if(Talk == true)
        {
            Dialog.SetActive(true);  
        }
        else
        {
            Dialog.SetActive(false);
        }
        
    }
}
