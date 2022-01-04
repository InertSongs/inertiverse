using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OtherUnitsInRange
{
    public static List<GameObject> SetTargets(Ability ability)
    {
        List<GameObject> theseTargets = new List<GameObject>();
        foreach(GameObject thisUnit in Initiative.shellOrder)
        {
            if(thisUnit != Initiative.activePlayer.unit)
            {
                theseTargets.Add(thisUnit);   
            }
        }
        return SetRange.Set(theseTargets, ability.actionRange, Initiative.activePlayer.unit);
    }
}
