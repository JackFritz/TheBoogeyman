using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDesert : MonoBehaviour
{
    // Start is called before the first frame update
    public void Next()
    {
        SceneManager.LoadScene("Desert");
    }
}