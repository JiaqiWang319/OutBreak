using UnityEngine;
using System.Collections;

public class resourceCard : MonoBehaviour {

    public string Name;
    public Object resourceCardImg;
    public string function1 = null;
    public string function2 = null;
    public int id;
    public int toSubmitSignal = 0;// this is for the player to have a decision about if submit this card to the team, 0=not, 1=yes
}
public class ResourceCardInformation : MonoBehaviour
{
   static public resourceCard resourceCard1;
    static public resourceCard resourceCard2;
    static public resourceCard resourceCard3;
    static public resourceCard resourceCard4;
    static public resourceCard resourceCard5;
    static public resourceCard resourceCard6;
    static public resourceCard resourceCard7;
    static public resourceCard resourceCard8;
    static public resourceCard resourceCard9;
    static public resourceCard resourceCard10;
    static public resourceCard resourceCard11;
    static public resourceCard resourceCard12;
    static public resourceCard resourceCard13;
    static public resourceCard resourceCard14;
    static public resourceCard resourceCard15;
    static public resourceCard resourceCard16;
     static public resourceCard resourceCard17;
    static public resourceCard resourceCard18;
    static public resourceCard resourceCard19;
    static public resourceCard resourceCard20;
 // add more resourceCard here



    void start()
    {
        resourceCard1.Name = "";
        resourceCard1.resourceCardImg = GameObject.Find("");
        resourceCard1.function1 = "";
        resourceCard1.function2 = "";
        
        //input more information of the resource cards here
    }
}

