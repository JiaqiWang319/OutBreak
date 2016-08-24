using UnityEngine;
using System.Collections;
public class GameSetup : MonoBehaviour {

    static public int numOfPlayer = 0;
    static public int mapcardNum = 10;// we assume that there are 10 map cards, you can change the number of map cards here
    static public int resourceCardNum = 20;//we assume that there are 20 resource cards now, you can change the number of the cards here
    public int  randomNumber = 0;
    public int randomNumber2 = 0;
  static public  MapCard[] MapArray = new MapCard[mapcardNum ];
  static  public resourceCard[] resourceCardArray = new resourceCard[resourceCardNum ];
    int i = 0;// a signal to calculate how many map cards have been put into the Array
    int x = 0;// a signal to calculate how many resource cards have been put into the Array
    // Use this for initialization
    void Start () {
        print("please input player number~");
        numOfPlayer = 4;// you can change the number of player here. now in this code it set up in 4 players
        mapArray();
        resourceArray();

        }


   void draw3card()
    {
        playerData.player1.card1 = resourceCardArray[0];
        playerData.player1.card2 = resourceCardArray[1];
        playerData.player1.card3 = resourceCardArray[2];

        playerData.player2.card1 = resourceCardArray[3];
        playerData.player2.card2 = resourceCardArray[4];
        playerData.player2.card3 = resourceCardArray[5];

        playerData.player3.card1 = resourceCardArray[6];
        playerData.player3.card2 = resourceCardArray[7];
        playerData.player3.card3 = resourceCardArray[8];


    }


    void mapArray()
    {
        while (i < 10)// change the number of 10 when you want to add more cards
        {
            randomNumber = Random.Range(1, mapcardNum);

            if (MapArray[randomNumber] == null)
            {
                if (i == 0)
                {
                    MapArray[randomNumber] = Map.map1;
                    i++;
                }
                if (i == 1)
                {
                    MapArray[randomNumber] = Map.map2;
                    i++;

                }
                if (i == 2)
                {
                    MapArray[randomNumber] = Map.map3;
                    i++;
                }
                if (i == 3)
                {
                    MapArray[randomNumber] = Map.map4;
                    i++;
                }
                if (i == 4)
                {
                    MapArray[randomNumber] = Map.map5;
                    i++;
                }
                if (i == 5)
                {
                    MapArray[randomNumber] = Map.map6;
                    i++;
                }
                if (i == 6)
                {
                    MapArray[randomNumber] = Map.map7;
                    i++;
                }
                if (i == 7)
                {
                    MapArray[randomNumber] = Map.map8;
                    i++;
                }
                if (i == 8)
                {
                    MapArray[randomNumber] = Map.map9;
                    i++;
                }
                if (i == 9)
                {
                    MapArray[randomNumber] = Map.map10;
                    i++;
                }
                // add more similar code when you want to add more card
            }
        }
    }


  void resourceArray()
    {
        while (x < 20)// change the number of 10 when you want to add more cards
        {
            randomNumber2 = Random.Range(1, resourceCardNum);

            if (resourceCardArray [randomNumber2] == null)
            {
                if (x  == 0)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard1;
                    x++;
                }
                if (x == 1)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard2;
                    x++;
                }
                if (x == 2)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard3;
                    x++;
                }
                if (x == 3)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard4;
                    x++;
                }
                if (x == 4)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard5;
                    x++;
                }
                if (x == 5)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard6;
                    x++;
                }
                if (x == 6)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard7;
                    x++;
                }
                if (x == 7)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard8;
                    x++;
                }
                if (x == 8)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard9;
                    x++;
                }
                if (x == 9)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard10;
                    x++;
                }
                if (x == 10)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard11;
                    x++;
                }
                if (x == 11)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard12;
                    x++;
                }
                if (x == 12)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard13;
                    x++;
                }
                if (x == 13)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard14;
                    x++;
                }
                if (x == 14)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard15;
                    x++;
                }
                if (x == 15)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard16;
                    x++;
                }
                if (x == 16)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard17;
                    x++;
                }
                if (x == 17)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard18;
                    x++;
                }
                if (x == 18)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard19;
                    x++;
                }
                if (x == 19)
                {
                    resourceCardArray[randomNumber] = ResourceCardInformation.resourceCard20;
                    x++;
                }

                // add more similar code when you want to add more card
            }
        }
    }

    
}
