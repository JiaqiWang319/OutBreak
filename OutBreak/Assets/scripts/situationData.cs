using UnityEngine;
using System.Collections;

public class situationData : MonoBehaviour {

    decimal dieNumber = 0;
    /*
    static public placeData  nowPlaceData;

    public placeData place1;
    public placeData place2;
    public placeData place3;
    */
   static  public int gotoredSignal = 0;
   static  public int gotogreenSignal = 0;
   static  public int stopSignal = 0;
    static public int rollDieSignal = 0;
    string rollDie;

    static public string[] placeArray = new string[10] { "red", "green", "stop", "red", "green", "green", "red", "red", "stop", "green" };// here is only an example of the place, later coder could change the context of the array with new map of the board 
    public int i = 0;// use for call for the array of placeArray string, placeArray[i]

    // Use this for initialization
    void Start () {
       
  
	}
	
	// Update is called once per frame
	void Update () {
        //click the sign to roll die
        /*
        if the sign has been clicked
        rollDie = "Yes";
        */
        if (rollDie =="Yes")
        {
            dieNumber = RollRegularDie.rollRegularDie();
            rollDie = "No";
            rollDieSignal = 1;

        }
        //if roll die
         findTileType(dieNumber);


    }

  void findTileType(decimal die)
    {
     
        while(die > 0 && stopSignal ==0)    //go front, if there is a stop sign, output stop signal
        {
            die--;
            i++;
            if (placeArray[i] == "stop" )
            {
                stopSignal = 1;
            }
        }
        // if there is no stop on the way, then judge the token is on the red or green area?
        if (placeArray [i] == "red")
        {
            gotoredSignal = 1;

        }
        else if (placeArray [i]== "green")
        {
            gotogreenSignal = 1;

        }

    }
}
/*
public class placeData: MonoBehaviour
{
    public int id;
    public string color;
    public GameObject placeImg;

}
*/


