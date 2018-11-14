using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharClass
{
	public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "?";
        Stamina = 15;
        Endurance = 12;
        Strength = 14;
        Intellect = 10;
    }
}
