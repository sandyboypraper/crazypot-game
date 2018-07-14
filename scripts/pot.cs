using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pot : MonoBehaviour {

    Animator anim;
    public SpriteRenderer obj;
    Vector3 vec;
    public gamespeed gamespeedscript;
    public float speed ;
    Canvas can;
    CircleCollider2D bc;
    Camera c;
   

   

    void Start () {

       
        c = Camera.main;
        bc = GetComponent<CircleCollider2D>();
        vec = transform.position;      
        anim = GetComponent<Animator>();
        obj.enabled = false;
	}
	
	
	void Update () {

            vec.y = vec.y - speed * Time.deltaTime;
            transform.position = vec;   
        
            if(Input.GetMouseButtonDown(0))
        {
           
            if(bc.OverlapPoint(c.ScreenToWorldPoint(Input.mousePosition)))
            {
               
                obj.enabled = true;
                transform.tag = "withpoty";
                anim.Play("clicked");           
            }
        }
    }

    /*private void OnMouseDown()
    {
        obj.enabled = true;
        transform.tag = "withpoty";
        anim.Play("clicked");
    }*/

 
}
