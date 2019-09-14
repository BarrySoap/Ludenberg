using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 100;
    private float energy = 0;
    private float maxEnergy = 200;
    private int initiative = 5;

    private int battleInitiative;

    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    public float Energy
    {
        get { return energy; }
        set { energy = value; }
    }

    public float MaxEnergy
    {
        get { return maxEnergy; }
        set { maxEnergy = value; }
    }

    public int Initiative
    {
        get { return initiative; }
        set { initiative = value; }
    }

    public void IncreaseInitiative(int factor)
    {
        battleInitiative *= factor;
    }

    private void Awake()
    {
        battleInitiative = initiative;
    }

    public void Update()
    {
        if (BattleController.battleStarted == true)
        {
            if (this.energy < maxEnergy)
            {
                this.energy += (1.0f * battleInitiative) / 10;
            }
            else if (this.energy > maxEnergy)
            {
                this.energy = maxEnergy;
            }
        }
    }
}
