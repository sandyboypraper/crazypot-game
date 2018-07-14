using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons1 : MonoBehaviour {

    public AudioSource au;
     public AudioClip c;

    private void Start()
    {
        au.PlayOneShot(c);
    }

    public void back()
    {
       
        Application.LoadLevel(0);
    }
}
