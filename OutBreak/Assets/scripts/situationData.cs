using UnityEngine;
using System.Collections;

public class situationData : MonoBehaviour {

    static public placeData  nowPlaceData;
    decimal  dieNumber = 0;

    public placeData place1;
    public placeData place2;
    public placeData place3;

   static  public int gotoredSignal = 0;
   static  public int gotogreenSignal = 0;
   static  public int stopSignal = 0;

    // Use this for initialization
    void Start () {

        place1.id = 1;
        place1.color = "red";
        place1.placeImg = GameObject.Find("");  
       
  
	}
	
	// Update is called once per frame
	void Update () {
        dieNumber = RollRegularDie.rollRegularDie();
        //if roll die
         findTileType(dieNumber, nowPlaceData );


    }

  void findTileType(decimal die,placeData nowPlace)
    {

        if(die > 0 && stopSignal ==0)    //go front, if there is a stop sign, output stop signal
        {
            die--;
            nowPlace.id ++;
            if (nowPlace.color   == "stop" )
            {
                stopSignal = 1;
            }
        }
        // if there is no stop on the way, then judge the token is on the red or green area?
        if (nowPlace.color  == "red")
        {
            gotoredSignal = 1;

        }
        else if (nowPlace.color== "green")
        {
            gotogreenSignal = 1;

        }

    }
}
public class placeData: MonoBehaviour
{
    public int id;
    public string color;
    public GameObject placeImg;

}


