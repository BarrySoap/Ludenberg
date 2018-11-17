using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour
{
	public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");

    }
}
