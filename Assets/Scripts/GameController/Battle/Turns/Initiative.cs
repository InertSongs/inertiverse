using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Initiative : MonoBehaviour
{
    public EventInitiativeList initiativeList;
    List<CurrentInitiativeOrder> currentInitiativeOrder = new List<CurrentInitiativeOrder>();
    public void addInitiative(GameObject initiative)
    {    
        currentInitiativeOrder.Add(new CurrentInitiativeOrder(initiative, initiative.GetComponent<UnitLoader>().sheet.sheetDex));
        currentInitiativeOrder.Sort();
        initiativeList.Raise(currentInitiativeOrder);   
    }
}
