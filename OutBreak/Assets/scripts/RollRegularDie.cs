using UnityEngine;
using System.Collections;
using System;

public class RollRegularDie : MonoBehaviour
{
    static public decimal rollRegularDie()
    {
        decimal randNum = 0;
        decimal diceNumber = 0;

        randNum = UnityEngine.Random.Range(1, 7);
        diceNumber = Math.Floor(randNum);

        if (diceNumber == 7)
        {
            diceNumber = 6;
        }

        return diceNumber;
    }
}
