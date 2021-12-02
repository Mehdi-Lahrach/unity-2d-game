using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class gameOver : MonoBehaviour
{

    public TextMeshProUGUI scoretext;
   
    private void Update()
    {
        scoretext.text = PlayerPrefs.GetInt("coin amont").ToString() +" " + "Coins" ;
    }
    public void restart()
    {
        SceneManager.LoadScene("game");
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
