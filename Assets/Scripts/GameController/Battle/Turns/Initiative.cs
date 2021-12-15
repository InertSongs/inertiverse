using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Initiative : MonoBehaviour
{
    public EventInitiativeList initiativeList;
    private int dex;
    List<CurrentInitiativeOrder> currentInitiativeOrder = new List<CurrentInitiativeOrder>();
    public void addInitiative(GameObject initiative)
    {
        //adding base stats dex and racial modifier
        dex = initiative.GetComponent<UnitLoader>().sheet.race.stats.dex + initiative.GetComponent<UnitLoader>().sheet.race.dexMod;
        currentInitiativeOrder.Add(new CurrentInitiativeOrder(initiative, dex));
        currentInitiativeOrder.Sort();
        initiativeList.Raise(currentInitiativeOrder);
        
    }
}
