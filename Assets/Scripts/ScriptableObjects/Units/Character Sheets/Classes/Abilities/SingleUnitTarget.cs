using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SingleUnitTarget : Ability
{    
    public override void Perform(bool manual)
    {
        if (manual == true)
        {
            List<CurrentInitiativeOrder> validTargets = OtherUnitsInRange.SetTargets(this);
        }
        else
        {

        }
    }
}
