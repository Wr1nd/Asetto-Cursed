using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeerColector : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public int beerBottles ;
    public AudioClip collectSound;
    
    void Update()
    {
        beerBottles = int.Parse(text.text);
    }
    
    //collect beer bottles
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(gameObject);
            beerBottles++;
            text.text = beerBottles.ToString();
        }
    }
}
