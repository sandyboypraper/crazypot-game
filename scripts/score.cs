using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text _score,_shitover,_highscore;
   public float scoreno;
    public float highscore;
    public AudioClip cl;
    public GameObject origion;
    seen seenscript;
    AudioSource loopplay;
    public bool incscore,newbestshitter;
   public float incspeed;
     public GameObject pot;
    pot potscrit;
   
    


    void Start () {
        newbestshitter = false;
        highscore = PlayerPrefs.GetFloat("highscore", highscore);      
        loopplay = GetComponent<AudioSource>();
        potscrit = pot.GetComponent<pot>();
        loopplay.Play();
        scoreno = 0;
        _score.enabled = false;
        _shitover.enabled = false;
        seenscript = origion.GetComponent<seen>();
        incspeed = 2;
        StartCoroutine(incscorebyone());
    }
	
	

	void Update () {

        _score.enabled = true;

        if (scoreno >= highscore)
        {
            newbestshitter = true;
            highscore = scoreno;
            PlayerPrefs.SetFloat("highscore", highscore);                  
        }
        else
        {
            newbestshitter = false;
        }

         if(Input.GetMouseButtonDown(0)  &&  incscore)
          {

            loopplay.PlayOneShot(cl);

            }

        if (incspeed > 0.5f)
            incspeed = 4 / potscrit.speed;


        _highscore.text = highscore.ToString();
        _score.text = scoreno.ToString() ;

        if (seenscript.shitover)
            _shitover.enabled = true;
       else
        {
            _shitover.enabled = false;
        }

    }

    IEnumerator incscorebyone()
    {
        while (true)
        {
            if (incscore)
                scoreno++;
            yield return new WaitForSeconds(incspeed);
        }
    }

}
