using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    public GameObject origion;
    seen seenscript;
    public bool hitone,gameover;

    private void Start()
    {
        hitone = true;
        seenscript = origion.GetComponent<seen>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.gameObject.transform.tag == "pot")
        {
            Destroy(collision.gameObject);
            if (hitone||gameover)
            {
                seenscript.play = false;
                seenscript.shitover = true;
                hitone = false;             
            }
        }
        if(collision.gameObject.transform.tag == "withpoty")
        {
            seenscript.make();
            Destroy(collision.gameObject);
        }
    }


   
}
