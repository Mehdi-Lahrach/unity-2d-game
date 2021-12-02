using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerCoin : MonoBehaviour
{
    public AudioSource coinSound;

    private void Start()
    {
        coinSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "coin")
        {
            coinSound.Play();
            Destroy(other.gameObject);
            coinCointerSkript.coinAmont++; 
        }
    }

   
}
