using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonitroBackspace : MonoBehaviour
{
    //reload level if backspace is pressed
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //reload scene
            Debug.Log("Backspace key was pressed.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    
}
