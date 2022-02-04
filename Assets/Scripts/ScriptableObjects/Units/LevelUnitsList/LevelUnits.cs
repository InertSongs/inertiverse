using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelUnits", menuName = "Stage Management/Level Units/New Level Unit Collection")]
public class LevelUnits : ScriptableObject
{
    public List<CharacterSheet> unitsInThisLevel;
    public void Populate(List<Transform> spawnLocationList)
    {
        Initiative.nextInitiativeOrder = new List<CharacterSheet>();
        for (int i = 0; i < spawnLocationList.Count; i++)
        {
            unitsInThisLevel[i].Spawn(spawnLocationList[i]);
        }
    }
}
