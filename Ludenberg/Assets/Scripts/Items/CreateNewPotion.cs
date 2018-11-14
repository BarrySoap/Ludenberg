using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour
{
    private BasePotion newPotion;
    
	void Start ()
    {
        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());
    }
	
	private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "Potion Desc";
        newPotion.ItemID = Random.Range(1, 101);
        ChoosePotionType();
    }

    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 7);

        switch (randomTemp)
        {
            case 0:
                newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
                break;
            case 1:
                newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
                break;
            case 2:
                newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
                break;
            case 3:
                newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
                break;
            case 4:
                newPotion.PotionType = BasePotion.PotionTypes.VITALITY;
                break;
            case 5:
                newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
                break;
            case 6:
                newPotion.PotionType = BasePotion.PotionTypes.SPEED;
                break;
        }
    }
}
