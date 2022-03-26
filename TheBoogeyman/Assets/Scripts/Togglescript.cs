using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Togglescript : MonoBehaviour
{

    public GameObject Dialog;
    public GameObject Player;

    public bool Talk;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Talk = true;
            Debug.Log("Enterd Tri");
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Talk = false;
    }
    
    // Update is called once per frame
    void Update()
    {
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
