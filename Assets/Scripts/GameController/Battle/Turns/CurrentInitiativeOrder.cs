using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CurrentInitiativeOrder : IComparable<CurrentInitiativeOrder>
{
    public GameObject unit;
    private int dex;
    public CharacterSheet sheet;

    public CurrentInitiativeOrder(GameObject newUnit, CharacterSheet newSheet)
    {
        unit = newUnit;
        dex = newSheet.sheetDex;
        sheet = newSheet;
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

