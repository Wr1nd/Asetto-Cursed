using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonitorKey : MonoBehaviour
{
    //check if Space is pressed
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //load scene level 1
            Debug.Log("Space key was pressed.");
            SceneManager.LoadScene("Assets/Scenes/Level1.unity");
            
            
        }
    }
}
