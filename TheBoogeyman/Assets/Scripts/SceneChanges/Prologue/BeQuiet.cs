using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeQuiet : MonoBehaviour
{
    // Start is called before the first frame update
    public void Next()
    {
        SceneManager.LoadScene("BeQuiet");
    }
}
