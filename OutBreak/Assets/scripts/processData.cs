using UnityEngine;
using System.Collections;

public class processData : MonoBehaviour {

    int diamondsNumber = 0;
    int whoesTurn = 0;
    // Use this for initialization
    void Start () {
        diamondsNumber = RollAntidoteDice.rollAntidoteDice();
        //if move the token
        whoesTurn++;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
