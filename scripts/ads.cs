using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class ads : MonoBehaviour {

    public score scorescript;

	public void showadd()
    {
         if(Advertisement.IsReady())
         {
            
             Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = handel});

         }

      

    }

    private void handel(ShowResult result)
    {
        switch(result)
        {
            case ShowResult.Finished:
                scorescript.scoreno = scorescript.scoreno + 15;
                break;
            case ShowResult.Skipped:
                scorescript.scoreno = scorescript.scoreno + 5;
                break;
            case ShowResult.Failed:            
                break;
        }

    }
	
}
