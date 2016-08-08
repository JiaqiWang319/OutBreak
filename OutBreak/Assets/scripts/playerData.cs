using UnityEngine;
using System.Collections;

public class playerData : MonoBehaviour {

   public player player1;
   public player player2;
   public player player3;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
        //if resource card1 belongs to player1
        player1.card1 = ResourceCardInformation.resourceCard1;
        player1.batteryNumber = 3;
        //if player1 ask one question
      //  player1.batteryNumber--;
        //if player go out from one room
      //  player1.batteryNumber = 3;  
    }
}
public class player: MonoBehaviour
{
    int id;
    public resourceCard card1;
    public resourceCard card2;
    public resourceCard card3;
    public int batteryNumber;
}
