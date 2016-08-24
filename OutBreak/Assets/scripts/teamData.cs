using UnityEngine;
using System.Collections;

public class teamData : MonoBehaviour {

    public resourceCard teamMember1;
    public resourceCard teamMember2;
    public resourceCard teamMember3;
    public int teamMemberSignal=0;     //1= have one team member now, 2=2 members,3=3 members 
    public MapCard nowMap;

    public int toSubmitButton = 0;// there is a button on the screen for player to decide if they want to submit,1=yes,0=no 
    int matchNum = 0;// how many of the fuction of the team match the win conditions
    string result;

    public int winCondition1Signal = 0;
    public int winCondition2Signal = 0;
    public int winCondition3Signal = 0;

    public int check = 0;// to check if there has no more than 3 team member,0=yes,1=no
    // Use this for initialization
    void update ()
    {

        chooseTeam();
        if(check ==0)// check =0 means that the number of team member is OK, if not, there are more than 3 members so you can not press the sumbit button
        {
            //if you press the button, then
            toSubmitButton = 1;
        }


        // add more code for judging if the palyer sumbit the card
        if (toSubmitButton == 1)
        {
            if (nowMap.numWinConditions == winOrNot())
            {

                result = "Win";
            }
            else
            {
                result = "Lose";
            }
            print(result);
            if (result=="Lose")
            {

            }
            clear();
            
        }
    }
	// this function is to call for the compare function with the three team members and then we can know if they win or not in this room
    int winOrNot()
    {
        compare(teamMember1 ,nowMap );
        compare(teamMember2, nowMap );
        compare(teamMember3 ,nowMap );
        return matchNum ; // this is used when we judge if the match number is equal to the number of win condition

    }
    // this function is used to compare that if one of the teamMember has the function same with the win condition
    void  compare(resourceCard teamMember, MapCard map)
    {
       
        if (teamMember.function1 == map.winCondition1)
        {
            if (winCondition1Signal == 0)          // this kind of signal is to avoid the re-calculate of the match number, when there is more than one function of the same kind
            {
                matchNum++;
                winCondition1Signal = 1;
            }
      
        }
        if(teamMember.function1 == map.winCondition2)
        {
            if (winCondition2Signal == 0)
            {
                matchNum++;
                winCondition2Signal = 1;
            }
        }
        if (teamMember.function1 == map.winCondition3)
        {
            if (winCondition3Signal == 0)
            {
                matchNum++;
                winCondition3Signal = 1;
            }
        }
        // function 2 of the team member
        if (teamMember.function2 == map.winCondition1)
        {
            if (winCondition1Signal == 0)
            {
                matchNum++;
                winCondition1Signal = 1;
            }

        }
        if (teamMember.function2 == map.winCondition2)
        {
            if (winCondition2Signal == 0)
            {
                matchNum++;
                winCondition2Signal = 1;
            }
        }
        if (teamMember.function2 == map.winCondition3)
        {
            if (winCondition3Signal == 0)
            {
                matchNum++;
                winCondition3Signal = 1;
            }
        }


    }

    void toSubmitSignal(resourceCard card)
    {
        if (card.toSubmitSignal  == 1)           //if player1 send his card1 to the team
        {
            teamMemberSignal++;
            if (teamMemberSignal == 1)
            {
                teamMember1 = card;
            }
            if (teamMemberSignal == 2)
            {
                teamMember2 = card;
            }
            if (teamMemberSignal == 3)
            {
                teamMember3 = card;
            }
            if (teamMemberSignal == 4)
            {
                print("Warning! The number of team member is more than required");
                teamMemberSignal = 3;
                check= 1;
            }

        }
    }
    // this function clear all of the toSubmitSignal, when their one round choose has been done
    void clear()
    {
        playerData.player1.card1.toSubmitSignal = 0;   //Add more cards to the max number of the card that one player can have
        playerData.player1.card2.toSubmitSignal = 0;
        playerData.player1.card3.toSubmitSignal = 0;
        playerData.player2.card1.toSubmitSignal = 0;
        playerData.player2.card2.toSubmitSignal = 0;
        playerData.player2.card3.toSubmitSignal = 0;
        playerData.player3.card1.toSubmitSignal = 0;
        playerData.player3.card2.toSubmitSignal = 0;
        playerData.player3.card3.toSubmitSignal = 0;
    }
    // find which card of the player has been sent to the team 
    void loseCard(player player)
    {
        if(player.card1.toSubmitSignal ==1)
        {
            player.card1 = null;
        }
        if (player.card2.toSubmitSignal == 1)
        {
            player.card2 = null;
        }
        if (player.card3.toSubmitSignal == 1)
        {
            player.card3 = null;
        }

    }
    // call for loseCard function to let each player lose the card they have sent when they lose
    void findLoseCard()
    {
        loseCard(playerData.player1);
        loseCard(playerData.player2);
        loseCard(playerData.player3);


    }

    void chooseTeam()
    {
        // input the signal of whether choose which card
        // here take an example of choosing each card1 of each player
        playerData.player1.card1.toSubmitSignal = 1;
        playerData.player1.card2.toSubmitSignal = 0;
        playerData.player1.card3.toSubmitSignal = 0;
        playerData.player2.card1.toSubmitSignal = 1;
        playerData.player2.card2.toSubmitSignal = 0;
        playerData.player2.card3.toSubmitSignal = 0;
        playerData.player3.card1.toSubmitSignal = 1;
        playerData.player3.card2.toSubmitSignal = 0;
        playerData.player3.card3.toSubmitSignal = 0;

    }
    void changeSignal()
    {
        toSubmitSignal(playerData.player1.card1);           //if player1 send his card1 to the team
        toSubmitSignal(playerData.player1.card2);
        toSubmitSignal(playerData.player1.card3);
        toSubmitSignal(playerData.player2.card1);
        toSubmitSignal(playerData.player2.card2);
        toSubmitSignal(playerData.player2.card3);
        toSubmitSignal(playerData.player3.card1);
        toSubmitSignal(playerData.player3.card2);
        toSubmitSignal(playerData.player3.card3);

    }
}
