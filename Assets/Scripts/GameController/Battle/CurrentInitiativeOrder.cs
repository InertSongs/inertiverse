using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CurrentInitiativeOrder : IComparable<CurrentInitiativeOrder>
{
    public GameObject unit;
    public int dex;

    public CurrentInitiativeOrder(GameObject newUnit, int newDex)
    {
        unit = newUnit;
        dex = newDex;
    }
    
    public int CompareTo(CurrentInitiativeOrder other)
    {
        if (other == null)
        {
            return 1;
        }
        return other.dex-dex;
    }
}

