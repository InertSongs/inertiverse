using System.Collections.Generic;
using UnityEngine;

public class OtherUnitsInRange
{
    public static List<CharacterSheet> SetTargets(Ability ability)
    {
        List<GameObject> targetsToCheck = new List<GameObject>();
        foreach (CharacterSheet sheet in Initiative.nextInitiativeOrder)
        {
            GameObject thisUnit = sheet.shell;
            if (thisUnit != Initiative.activeShell)
            {
                targetsToCheck.Add(thisUnit);
            }
        }
        List<CharacterSheet> returnTargets = new List<CharacterSheet>();
        foreach (GameObject thisUnit in SetRange.Set(targetsToCheck, ability.actionRange, Initiative.activeShell))
        {
            CharacterSheet targetSheet = null;
            foreach (CharacterSheet sheet in Initiative.nextInitiativeOrder)
            {
                if (sheet.shell == thisUnit)
                {
                    targetSheet = sheet;
                }
            }
            returnTargets.Add(targetSheet);
        }
        return returnTargets;
    }
}
