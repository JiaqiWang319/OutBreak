using UnityEngine;
using System.Collections;

public class situationData : MonoBehaviour {

    int nowPlaceId = 0;
    int dieNumber = 0;

    public placeData place1;
    public placeData place2;
    public placeData place3;

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
         GoOn(dieNumber, nowPlaceId);


    }

    void GoOn(int die,int nowPlace)
    {
        int gotoredSignal = 0;
        int gotogreenSignal = 0;
        int stopId = 0;
        int redId = 0;
        int greenId = 0;
        int stop = 0;
        if(die > 0 && stop ==0)    //go front, if there is a stop sign, output stop signal
        {
            die--;
            nowPlace++;
            if (nowPlace  == stopId )
            {
                stop = 1;
            }
        }
        // if there is no stop on the way, then judge the token is on the red or green area?
        if (nowPlace == redId)
        {
            gotoredSignal = 1;

        }
        else if (nowPlace == greenId)
        {
            gotogreenSignal = 1;

        }

    }
}
public class placeData: MonoBehaviour
{
    public int id;
    public string color;
    public Object placeImg;

}


