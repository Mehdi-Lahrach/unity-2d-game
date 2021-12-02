using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadWinScene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            PlayerPrefs.SetInt("coin amont", coinCointerSkript.coinAmont);
            coinCointerSkript.coinAmont = 0;
            SceneManager.LoadScene("WinScene");
        }
    }
}
