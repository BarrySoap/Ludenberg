using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("STAMINA", GameInformation.Stamina);
        PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
    }
}
