using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SingleUnitTarget : Ability
{
    public override void PerformManual()
    {
        UI.GetComponent<UIController>().OpenMenu(OtherUnitsInRange.SetTargets(this));
    }
}
