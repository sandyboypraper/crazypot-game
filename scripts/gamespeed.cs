using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamespeed : MonoBehaviour
{

    public GameObject pot;
    pot potscript;

    void Start()
    {
        potscript = pot.GetComponent<pot>();
        potscript.speed = 4;
        InvokeRepeating("speedup", 3f, 4);
    }

    void speedup()
    {
        potscript.speed = potscript.speed + 0.1f;
    }

}
