using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player name: " + GameInformation.PlayerName);
        Debug.Log("Player level: " + GameInformation.PlayerLevel);
        Debug.Log("Player stamina: " + GameInformation.Stamina);
        Debug.Log("Player endurance: " + GameInformation.Endurance);
        Debug.Log("Player intellect: " + GameInformation.Intellect);
        Debug.Log("Player strength: " + GameInformation.Strength);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
