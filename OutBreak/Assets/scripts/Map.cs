using UnityEngine;
using System.Collections;

public class MapCard 
{

    public string title;
    public Object mapImg;
    public string fulldescription;
    public string hiddenScription;
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
    static public MapCard map3;
    static public MapCard map4;
    static public MapCard map5;
    static public MapCard map6;
    static public MapCard map7;
    static public MapCard map8;
    static public MapCard map9;
    static public MapCard map10;

    // add more map cards here with the class of MapCard




    // Use this for initialization
    void Start () {
        // add the information data of each map card, the map1 and map2 are just examples
        // there is not the whole information of map cards, so later coder should add the infromation of map cards here
        map1.title = "Biologglab";
        map1.mapImg = GameObject.Find("map1Img");// the object is not exist in this code, so we need the coder of interface add the name of the object of the map to this place
        map1.fulldescription = "good";
        map1.id = 1;
        map1.numWinConditions = 2;
        map2.title = "";
        map2.mapImg = GameObject.Find("");
        map2.fulldescription = "";
        map2.id = 2;
        
    }

}
