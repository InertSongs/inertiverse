using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherUnitsInRange
{
    public static List<CurrentInitiativeOrder> SetTargets(Ability ability)
    {
        List<CurrentInitiativeOrder> theseTargets = new List<CurrentInitiativeOrder>();
        foreach(CurrentInitiativeOrder thisUnit in ability.initiative.currentInitiativeOrder)
        {
            if(thisUnit != ability.initiative.activePlayer)
            {
                theseTargets.Add(thisUnit);
            }
        }
        return SetRange.Set(theseTargets, ability.actionRange, ability.initiative.activePlayer.unit);
    }
}
