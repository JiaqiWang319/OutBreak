using UnityEngine;
using System.Collections;

public class drawResourceCard : MonoBehaviour {


    static public int whichResourceCard=9;// it from 9 because 0 to 8 has been given to the 3 players

	
	// Update is called once per frame
	void Update () {
	if (situationData .gotogreenSignal ==1)
        {
            print("please draw a new resource card");
            drawCard(findNullPlace(playerData.player1));           
        }
	}
    //Find which card palce is null
    resourceCard findNullPlace(player player)
    {
        if (player.card1 == null)
        {
            return player.card1;
        }
        else if (player.card2 == null)
        {
            return player.card2;
        }
        else if (player.card3 == null)
        {
            return player.card3;
        }
        else return player.card4  ;  // now the max number of cards a player have is 4, you should add more cards to the player in future before it is played
    }
    //give that card to that place
    void drawCard(resourceCard card)
    {
        card = GameSetup.resourceCardArray[whichResourceCard ];
        whichResourceCard++;
    }
}
