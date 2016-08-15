using UnityEngine;
using System.Collections;

public class teamData : MonoBehaviour {

    public resourceCard teamMember1;
    public resourceCard teamMember2;
    public resourceCard teamMember3;

    public MapCard nowMap;

    int matchNum = 0;
    string result;
    // Use this for initialization
    void Start ()
    {

        //if player1 send his card1 to the team
        teamMember1 = playerData.player1.card1;
        //if player2 send his card2 to the team
        teamMember2 = playerData.player2.card2;
        //if player3 send his card1 to the team
        teamMember3 = playerData.player3.card1;

        if (nowMap.numWinConditions == winOrNot())
        {
           
            result = "Win";
        }
        else
        {
            result = "Lose";   
        }
        print(result);

    }
	
    int winOrNot()
    {
        compare(teamMember1 ,nowMap );
        compare(teamMember2, nowMap );
        compare(teamMember3 ,nowMap );
        return matchNum ;

    }
    void  compare(resourceCard teamMember, MapCard map)
    {
     
        if (teamMember.function1 == map.winCondition1 || teamMember.function1 == map.winCondition2 || teamMember.function1 == map.winCondition3)
        {
            matchNum ++;
        }
        if (teamMember.function2 == map.winCondition1 || teamMember.function2 == map.winCondition2 || teamMember.function2 == map.winCondition3)
        {
           matchNum ++;
        }

    }
}
