# OutBreak
A digital game

BY Jiaqi Wang

Outbreak is a race-the-clock, card-matching, hidden information game for 3-5 players ages 9 and up. It is collaborative¡ªeither everyone wins, or everyone loses. 
Its runtime for new players is about 40 minutes. Experienced players can play the game in about 20.

Functions:

1.     int RollRegularDie()

When you click on the die, it will show a number (from 1 to 6). This number will return after called and will be used by the ¡°moveToken()¡± function.

The type of random number change into decimal to produce the random number of the dice.

2.    int RollAntidoteDice()

There are six Dice and each has half chance having A on it.

Click the dice and then they will show randomly, blank or A.

This function will finally return the number of ¡°A¡±. 


There are 6 random class, this 6 random class represent to the 6 dice which are rolled to decide the number of diamonds they get.
The "int" type of function is to roll that 6 dice,it will return the number of the "A" on the 6 dice randomly.
There is a random class, which is used to have the half possiblity to be "A".One of the class represent for one die.

3.    int getDiamonds()

Call for ¡°RollAntidoteDice()¡±, and then get the return number of ¡°A¡±.

Then players will get diamonds of antidote according to the number of ¡°A¡± shown on these 6 dices. (When they get 9 diamonds they will win)

This function will return the number of diamonds they have.


We have just put the data part of the diamonds number into the process.cs
So there is no code of this function. Later coder who will design the interface can add this later.

4.     moveToken()

Move the token with the number of the die in ¡°RollRegularDie()¡±

Now we just use the transfrom.position fucntion to change the place of the Token to the place it should be.

5.     drawARoom()

A Room name shown and some basic uncompleted information.

This part now is not needed:  
decideOnRoom():Ask the players if they want to use this room, or if they want to discard it and keep going


Then go to showQuestionCard().


The asking question interface part is not in the data structure now.(6 and 7 )
6.     showQuestionCard()

Randomly, by click on the icon to show question card in this round.

    With a timer in 2 min.

7.     startQuestion()

For players to input the question word in the blanket

For the robot to input the question to answer the question

(May be in voice in future)


8.     chooseTeam()

Prompt players to pick their team.

Drag the resource cards from each team of player to the blank place which means sending them into the lab.

submitTeam()

When players click ¡°Send Team¡± button or something similar, it should finalize the team 


9.     drawResouceCard()

When we move on the green area, add one resource card to your box.

resourceCard findNullPlace(player player):    Find which card palce is null
void drawCard(resourceCard card)         :    give that card to that place
    

10.  discardResouceCard()

Prompt that they must choose one card to discard 

When we move on the red area, just drag out a card from your own card box.


11. batteryToken()   This is an interface part.

The number of Battery according to the number of player.

Each time one player ask one question will lose one battery.





Data Structure

1.     mapData()

We need to know data of each room.

Name of the Room

Uncompleted information

Whole information

The resource needed

Room ID

Win condition

The definite data of each map card has not been add to the code. There is comments in the code to show where should add these.
 All of the infromation is initialized in the Map.cs start()

2.     playerData()

What resource cards they have.
How many battery token they have each round.

There is only 4 resource cards of one player. It has not been changed to the array type.
The battery Number should be linked with the askQuestion part. Now it is not in the code.


3.     situationData()

We need this function to know where the token is now.

The mark number of the area the token is on

The information of each area (green, red or stop)

We need interface link to make sure the die has been click to roll.This is not in the code now. There are some comments to clarify this
It call for the number of RollRegularDie.
We change the placeArray number of implement the process of go ahead one step by one step.
 (placeArray is a array of the map with the information on it such as"red"" green""stop")
The information of placeArray now is just an example information. You should change it with new map.

findTileType()

Is the tile the token stopped on a stop sign, a green area, or a red area? 

If there is a stop sign, we will go to ¡°drawARoom()¡±.

If there is a green area, we will go to ¡°drawResouceCard()¡±.

If there is a red area, we will go to ¡°discardResouceCard()¡±.


4.     processData()

Whose turn

How many diamonds they have

We check the number of diamonds updately. If there are 9 diamonds they will win.

5.     resourceCard()

Information of each resource card.
Name
Function
object

Initialize the information of each resource card in the start() function

6.    teamData()

What team they choose

Compare that with the team that lab need, and judge if it is right

showResults()

Show whether or not the players picked the right team, did they win or not? 



The tosubmitSignal function is used only to the 3 cards of each player.(So there is problem when a player has more than 3 cards, this condition, we can call for this fucntion more times)
