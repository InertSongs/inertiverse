using System.Collections.Generic;
using UnityEngine;

public class ActionTargets
{   
    public static List<CurrentInitiativeOrder> SetTargets(Initiative initiative, Ability ability)
    {
        List<CurrentInitiativeOrder> possibleTargets = new List<CurrentInitiativeOrder>();
        for(int i=0;i<initiative.currentInitiativeOrder.Count;i++)
        {
            if (initiative.currentInitiativeOrder[i] != initiative.activePlayer && Vector3.Distance(initiative.activePlayer.unit.transform.position,initiative.currentInitiativeOrder[i].unit.transform.position)<ability.actionRange)
            {
                possibleTargets.Add(initiative.currentInitiativeOrder[i]);
            }
        }
        return possibleTargets;
    }
}
