using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seen : MonoBehaviour {


   public mainmenu mainmenuscript;
    public GameObject mainmenuobj;
    public GameObject potprefeb;
    public GameObject[] where;
    //public GameObject potprefeb;
    public bool play;
    public float speed;
    Animator anim;
    Vector3 pos;
    public bool initiate;
    public bool shitover;
    public score scorescript;
  

	void Start () {     
        anim = mainmenuobj.GetComponent<Animator>();
        //play = true;
        speed = 5;
        // InvokeRepeating("make", 1f, 3/speed);      
	}


    private void LateUpdate()
    {

        // for first 6 blocks
        if (initiate)
        {
           
            foreach (GameObject obj in where)
            {
                GameObject obj1 = Instantiate(potprefeb, obj.transform.position, obj.transform.rotation);
                pos = obj.transform.position;
                float x = Random.Range(-16, 16);
                pos.x = x / 7;
                obj1.transform.position = pos;
            }
            initiate = false;
        }


        if (shitover)
        {
           
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("start", false);
                Invoke("main", 1.5f);             
                shitover = false;
            }
        }


        scorescript.incscore = play;
        
       
    }

    public void make()
    {
        if (play)
        {
            GameObject obj2 = Instantiate(potprefeb, where[0].transform.position, where[0].transform.rotation);
            pot po = obj2.GetComponent<pot>();        
            pos = where[0].transform.position;
            float x = Random.Range(-16, 16);
            pos.x = x / 7;
            obj2.transform.position = pos;
            // GameObject obj = Instantiate(potprefeb, transform.position, transform.rotation);
            // obj.transform.position = pos;
        }
      

    }

    void main()
    {
        mainmenuscript.on = true;
    }

}
