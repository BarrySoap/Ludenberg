using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    private BaseCharClass class1 = new BaseMageClass();
    private BaseCharClass class2 = new BaseWarriorClass();

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Intellect.ToString());
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Strength.ToString());
    }
}
