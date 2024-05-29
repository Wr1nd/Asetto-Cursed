using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlinkingText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float blinkSpeed = 5f;
    private float timer;
    private bool rising = false;
    
    
    //make smooth transition between alpha values. Make it go from 255 to 0 and then from 0 to 255
    void Update()
    {
        timer += Time.deltaTime * blinkSpeed;
        if (rising)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.Lerp(0, 1, timer));
        }
        else
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.Lerp(1, 0, timer));
        }

        if (timer > 1)
        {
            timer = 0;
            rising = !rising;
        }
    }
    
    
    
    
    
    

    
}
