using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCointerSkript : MonoBehaviour
{
    public Text coinText;
    public static int coinAmont = 0;
   
    void Start()
    {
        coinText = GetComponent<Text>();  
    }

   
    void Update()
    {
        coinText.text = coinAmont.ToString() + " " +"Coins";
       
    }
}
