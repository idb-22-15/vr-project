using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationCbScript : MonoBehaviour
{
    public void cb()
    {
        GameObject[] washers = GameObject.FindGameObjectsWithTag("Washer");
        Debug.Log("" + washers.Length);
    }
}
