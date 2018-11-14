using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStates : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;
    
	void Start ()
    {
        currentState = BattleStates.START;
	}
	
	void Update ()
    {
		switch (currentState)
        {
            case BattleStates.START:
                break;
            case BattleStates.PLAYERCHOICE:
                break;
            case BattleStates.ENEMYCHOICE:
                break;
            case BattleStates.LOSE:
                break;
            case BattleStates.WIN:
                break;
        }
	}

    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE:"))
        {
            currentState = (BattleStates)(((int)currentState + 1) % 5);
        }
    }
}
