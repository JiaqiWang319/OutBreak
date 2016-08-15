using UnityEngine;
using System.Collections;

public class moveToken : MonoBehaviour {


    placeData nowPlace;
    public GameObject token;



	
	// Update is called once per frame
	void Update () {
       
        // call for information from the situationData
        nowPlace = situationData.nowPlaceData;
       token.transform.position= nowPlace.placeImg.transform.position;

	}

}
