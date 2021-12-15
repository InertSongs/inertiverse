using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterSheet : ScriptableObject
{
    public UnitRace race;
    public void visuals(Transform spawnLocation)
    {
        Instantiate(race.baseModel, spawnLocation);
    }
}
