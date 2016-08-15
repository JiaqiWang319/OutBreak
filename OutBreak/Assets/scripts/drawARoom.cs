using UnityEngine;
using System.Collections;

public class drawARoom : MonoBehaviour {

    MapCard nowMap;
    public int whichMap;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update () {
	if (situationData.stopSignal==1)
        {
            print("You are going to draw a room");
            whichMap=Random.Range(0, 9);
            if (whichMap <= 1)
            {
                nowMap = Map.map1;
                //show the front information of  that map card
                //call for the showQuestion() part
            }
            if(whichMap>1&&whichMap <=2)
            {
                nowMap = Map.map2;
            }
            //....more map cards choice
             
        }
	}
}
