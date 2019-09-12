using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health = 100;
    private int energy = 0;
    private int initiative = 5;

    private int battleInitiative;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Energy
    {
        get { return energy; }
        set { energy = value; }
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
}
