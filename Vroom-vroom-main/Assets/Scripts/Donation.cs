using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donation : MonoBehaviour
{
    public void openChrome()
    {
        //open chrome
        System.Diagnostics.Process.Start("chrome.exe", "https://paypal.me/wr1nd");
    }
}
