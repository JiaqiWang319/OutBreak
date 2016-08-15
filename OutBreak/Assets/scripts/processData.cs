using UnityEngine;
using System.Collections;

public class processData : MonoBehaviour {

    int diamondsNumber = 0;
    int whoesTurn = 1;

	
	// Update is called once per frame
	void Update () {
        diamondsNumber = RollAntidoteDice.rollAntidoteDice();
        //if one player roll die
        if (situationData.rollDieSignal == 1)
        {
            if (whoesTurn == 5)
            {
                whoesTurn = 1;
            }
            else whoesTurn++;

            situationData.rollDieSignal = 0;

        }
    }
}
