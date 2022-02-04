using System;
using UnityEngine;

public class InitiativePair : IComparable<InitiativePair>
{
    public GameObject unit;
    private int dex;
    public CharacterSheet sheet;

    public InitiativePair(GameObject newUnit, CharacterSheet newSheet)
    {
        unit = newUnit;
        dex = newSheet.sheetDex;
        sheet = newSheet;
    }

    public int CompareTo(InitiativePair other)
    {
        if (other == null)
        {
            return 1;
        }
        return other.dex - dex;
    }
}

