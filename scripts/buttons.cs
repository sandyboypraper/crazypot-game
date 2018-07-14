using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {

    public Canvas c1,c2;
    AudioSource au;
    public AudioClip ac;

    private void Start()
    {
        au = GetComponent<AudioSource>();
        c1.enabled = true;
        c2.enabled = false;
        au.PlayOneShot(ac);
    }

    public void onclick()
    {
       
        Application.LoadLevel(1);
    }

    public void credit()
    {
        au.PlayOneShot(ac);
        c1.enabled = false;
        c2.enabled = true;
    }

    public void mainm()
    {
        au.PlayOneShot(ac);
        c1.enabled = true;
        c2.enabled = false;
    }
    public void Quit()
    {
        au.PlayOneShot(ac);
        Application.Quit();
    }
}
