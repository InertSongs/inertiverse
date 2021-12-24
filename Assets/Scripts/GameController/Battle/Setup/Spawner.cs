using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public List<SpawnsList> spawnsList = new List<SpawnsList>();
    private Vector3 spawnOffset = new Vector3(0,2,0);
    public EventGameObject initiative;
    
    public void Populate()
    {
        for (int i = 0; i < spawnsList.Count; i++)
        {
            Vector3 rotatedOffset = spawnsList[i].spawnLocation.transform.rotation * spawnOffset;
            GameObject thisUnit = Instantiate(spawnsList[i].shell, spawnsList[i].spawnLocation.transform.position + rotatedOffset, spawnsList[i].spawnLocation.transform.rotation);
            thisUnit.GetComponent<UnitLoader>().LoadUnit(spawnsList[i].sheet,thisUnit.transform);
            initiative.Raise(thisUnit);
        }
    }
    
    
}
