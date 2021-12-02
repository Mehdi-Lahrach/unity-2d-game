using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikTrap : MonoBehaviour
{
    public GameObject chektofall;
    private bool condition = true;
    public Vector2 spikePosition;

    void Update()
    {
        if(chektofall.GetComponent<CheckTofall>().isStanding && condition)
        {
            transform.position = spikePosition;
            condition = false;
        }
    }
}
