using UnityEngine;
using System.Collections;

public class MapCard 
{

    public string title;
    public Object mapImg;
    public string fulldescription;
    public int id;
    public int numWinConditions; 
    public string winCondition1;
    public string winCondition2;
    public string winCondition3;


}

public class Map :MonoBehaviour 
{

    static public MapCard map1;
   static  public MapCard map2;

    MapCard map3 = new MapCard();



    // Use this for initialization
    void Start () {

        map1.title = "Biologglab";
        map1.mapImg = GameObject.Find("map1Img");
        map1.fulldescription = "good";
        map1.id = 1;
        map1.numWinConditions = 2;
        map2.title = "";
        map2.mapImg = GameObject.Find("");
        map2.fulldescription = "";
        map2.id = 2;

        map3.title = "newtitle";
         


         
    }
	
	// Update is called once per frame
	void Update () {
   
    }
}
