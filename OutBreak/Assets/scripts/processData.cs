using UnityEngine;
using System.Collections;

public class processData : MonoBehaviour {

    int diamondsNumber = 0;
    // Use this for initialization
    void Start () {
        diamondsNumber = RollAntidoteDice.rollAntidoteDice();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
