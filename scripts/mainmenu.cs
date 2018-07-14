using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour {

    public Text bestshitter, highscore,newbestshitter;
    public  score scorescript;
   public pot potscript;
   public destroy destroyscript;
    public GameObject seenobj;
    seen seenscript;
    public bool on;
    public bool onafter;
    Animator anim;
    public GameObject particle;
    Camera c;
    bool atonce;
    public Image backbutton;
    public float randomizeadd;
   
     public ads adscript;


	void Start () {
        atonce = true ;
        on = true;
        c = Camera.main;
        backbutton.enabled = true;
        onafter = true;
        seenscript = seenobj.GetComponent<seen>();
        seenscript.initiate = false;
        seenscript.play = false;
        anim = GetComponent<Animator>();
        newbestshitter.enabled = false;
        randomizeadd = 1;
    }
	
	
	void Update () {
        if(!on)
        {
            bestshitter.enabled = false;
            highscore.enabled = false;
            backbutton.enabled = false;
            newbestshitter.enabled = false;
            atonce = true;
            onafter = false;
           
        }
        if(on)
        {
           
            bestshitter.enabled = true ;
            highscore.enabled = true;
            backbutton.enabled = true;
           
            if(scorescript.newbestshitter && atonce)
            {
                newbestshitter.enabled = true;
                Instantiate(particle, c.ScreenToWorldPoint(newbestshitter.transform.position), Quaternion.identity);
                atonce = false;
            }
            if ( scorescript.scoreno != 0 && atonce && randomizeadd == 1)
            {
                adscript.showadd();
                atonce = false;
            }
            seenscript.initiate = false;
            seenscript.play = false;
            onafter = true;
        }
        if (Input.GetMouseButton(0) && onafter)
        {       
            scorescript.scoreno = 0;
            on = false;
            anim.SetBool("start", true);
            Invoke("end",1.5f);
            randomizeadd = (randomizeadd == 1) ? (0) : (1);
        }
	}

 void end()
    {
        seenscript.initiate = true;
        potscript.speed = 3f;
        seenscript.play = true;
        destroyscript.hitone = true;
    }

}
