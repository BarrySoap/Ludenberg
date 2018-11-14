using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharClass
{
	public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "?";
        Stamina = 15;
        Endurance = 12;
        Strength = 14;
        Intellect = 10;
    }
}
