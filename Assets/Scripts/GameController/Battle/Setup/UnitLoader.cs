using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLoader : MonoBehaviour
{
    public int sheetDex;

    public void LoadUnit(CharacterSheet spawningUnit, Transform spawnLocation)
    {
        
        Instantiate(spawningUnit.visuals, spawnLocation);
        sheetDex = spawningUnit.race.dexMod + spawningUnit.unitStats.dex;
    }
}
