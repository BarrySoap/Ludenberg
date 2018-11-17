using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour
{
	public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");

        if (PlayerPrefs.GetString("EQUIPMENTITEM1") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment)PlayerPrefsSerialisation.Load("EQUIPMENTITEM1");
        }
    }
}
