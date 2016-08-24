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
            if (whichMap == GameSetup.mapcardNum)            //Add a catch, if at the end of the array, the game is over early, you lose
            {
                print("You Lose");

            }
            else                                            //Pull from that room card array from GameSetup.cs to find the next card
            {
                print("You are going to draw a room");
                nowMap = GameSetup.MapArray[whichMap];
                print(nowMap.hiddenScription);
                whichMap++;
            }
        }
	}
}
