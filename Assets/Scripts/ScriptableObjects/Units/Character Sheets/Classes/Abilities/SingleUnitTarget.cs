using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class SingleUnitTarget : Ability
{
    private List<CurrentInitiativeOrder> activeTargets;
    private List<CharacterSheet> activeSheets;
    private List<GameObject> activeShells;
    public override void PerformManual()
    {
        activeTargets = OtherUnitsInRange.SetTargets(this);
        activeSheets = activeTargets.Select(activeTargets => activeTargets.sheet).ToList();
        activeShells = activeTargets.Select(activeTargets => activeTargets.unit).ToList();
        UI.GetComponent<UIController>().OpenMenu(activeSheets);
    }
}
