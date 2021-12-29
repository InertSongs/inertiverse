using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelUnits : ScriptableObject
{
    private Vector3 spawnOffset = new Vector3(0, 2, 0);
    [SerializeField]
    private Initiative initiative;
    [SerializeField]
    private List<CharacterSheet> unitsInThisLevel;

    public void Populate(List<Transform> spawnLocationList)
    {
        for (int i = 0; i < spawnLocationList.Count; i++)
        {
            Vector3 rotatedOffset = spawnLocationList[i].rotation * spawnOffset;
            GameObject thisUnit = Instantiate(unitsInThisLevel[i].shell, spawnLocationList[i].position + rotatedOffset, spawnLocationList[i].rotation);
            initiative.addInitiative(thisUnit, unitsInThisLevel[i]);
        }
    }
}