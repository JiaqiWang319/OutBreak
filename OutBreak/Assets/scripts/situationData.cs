using UnityEngine;
using System.Collections;

public class situationData : MonoBehaviour {

    int diceNumber = 0;
    // Use this for initialization
    void Start () {

        diceNumber = RollRegularDie.rollRegularDie();
  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
