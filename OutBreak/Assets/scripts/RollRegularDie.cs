﻿using UnityEngine;
using System.Collections;

public class RollRegularDie : MonoBehaviour
{
    static public int rollRegularDie()
    {
        int random = 0;
        int diceNumber = 0;

        random = Random.Range(1, 7);

        if (random >= 1 && random < 2)
        {
            diceNumber = 1;

        }
        if (random >= 2 && random < 3)
        {
            diceNumber = 2;

        }
        if (random >= 3 && random < 4)
        {
            diceNumber = 3;

        }
        if (random >= 4 && random < 5)
        {
            diceNumber = 4;
        }
        if (random >= 5 && random < 6)
        {
            diceNumber = 5;
        }
        if (random >= 6 && random <= 7)
        {
            diceNumber = 6;
        }
        return diceNumber;
    }
}
