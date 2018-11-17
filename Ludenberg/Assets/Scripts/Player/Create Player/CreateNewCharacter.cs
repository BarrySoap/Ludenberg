using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private string playerName = "Enter Name";

    void Start()
    {
        newPlayer = new BasePlayer();
    }

    void Update()
    {

    }

    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName);

        if (GUILayout.Toggle(isMageClass, "Mage Class"))
        {
            isMageClass = true;
            isWarriorClass = false;
        }

        if (GUILayout.Toggle(isWarriorClass, "Warrior Class"))
        {
            isWarriorClass = true;
            isMageClass = false;
        }

        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }

            newPlayer.PlayerName = playerName;
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();
        }

        if (GUILayout.Button("Load Scene"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Stamina = newPlayer.Stamina;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Intellect = newPlayer.Intellect;
        GameInformation.Strength = newPlayer.Strength;
    }
}
