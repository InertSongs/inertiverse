using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OtherUnitsInRange
{
    public static List<CurrentInitiativeOrder> SetTargets(Ability ability)
    {
        List<GameObject> targetsToCheck = new List<GameObject>();
        foreach(GameObject thisUnit in Initiative.shellOrder)
        {
            if(thisUnit != Initiative.activePlayer.unit)
            {
                targetsToCheck.Add(thisUnit); 
            }
        }
        List<CurrentInitiativeOrder> returnTargets = new List<CurrentInitiativeOrder>();
        foreach(GameObject thisUnit in SetRange.Set(targetsToCheck, ability.actionRange, Initiative.activePlayer.unit))
        {
            returnTargets.Add(Initiative.nextInitiativeOrder[Initiative.shellOrder.IndexOf(thisUnit)]);
        }
        return returnTargets;
    }
}
