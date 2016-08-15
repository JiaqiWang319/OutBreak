using UnityEngine;
using System.Collections;

public class discardResourceCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (situationData .gotoredSignal ==1)
        {
            print("please discard one of your resource cards");
            //get the current player
            //if player1 discard card1
            playerData.player1.card1 = null;
        }

        
	}

}
