using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public Collider halfWayCollider;
    private float time;
    private bool isStarted;


    public GameObject FinalMenu;
    
    public TextMeshProUGUI timeGoal;
    public TextMeshProUGUI timeCurrent;
    public TextMeshProUGUI TimeTextMenu;
    public TextMeshProUGUI BeerGoal;
    public TextMeshProUGUI BeerCollected;
    public TextMeshProUGUI BeerTextMenu;

    public List<GameObject> stars;
    
    private int starsCollected = 1;
    
    
    void Start()
    {
        time = 0;
        isStarted = false;
        
    }
    
    void Update()
    {
        if (isStarted)
        {
            time += Time.deltaTime;
            //formas 00:00:00
            string minutes = Mathf.Floor(time / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            string milliseconds = ((time * 100) % 100).ToString("00");
            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
        }
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player") && !isStarted)
        {
            isStarted = true;
        }
        else if (other.gameObject.CompareTag("Player") && isStarted )
        {
            isStarted = false;
            CheckTime();
            BeerCollectedCheck();
            SetStars();
            FinalMenu.SetActive(true);
            
        }
        
        
    }

    private void CheckTime()
    {
        if (time <= int.Parse(timeGoal.text))
        {
            starsCollected++;
            //set the time text in the menu
            TimeTextMenu.text = Mathf.Floor(time) + "s";
            //set color green
            TimeTextMenu.color = Color.green;
        }
        else
        {
            //set the time text in the menu
            TimeTextMenu.text = Mathf.Floor(time) + "s";
            //set color red
            TimeTextMenu.color = Color.red;
        }
    }
    
    private void BeerCollectedCheck()
    {
        if (int.Parse(BeerCollected.text) >= int.Parse(BeerGoal.text))
        {
            starsCollected++;
            //set the beer text in the menu
            BeerTextMenu.text = BeerCollected.text;
            //set color green
            BeerTextMenu.color = Color.green;
        }
        else
        {
            //set the beer text in the menu
            BeerTextMenu.text = BeerCollected.text;
            //set color red
            BeerTextMenu.color = Color.red;
        }
    }
    
    private void SetStars()
    {
        for (int i = 0; i < starsCollected; i++)
        {
            stars[i].SetActive(true);
        }
    }
    
   
    
    

}
