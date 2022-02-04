using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSingleUnitTargetAbility", menuName = "Character Sheets/Abilities/Single Unit Target")]
public class SingleUnitTarget : Ability
{
    public override void SelectedInCombat()
    {
        ShowRange();
        SpawnTileSelector(this);
    }
    public override void ActionSelection(GameObject selection)
    {
        if (HitList(selection).Count > 0)
        {
                KillTileSelector();
                Attention.Affect(Initiative.activePlayer, HitList(selection)[0], attentionEffect);
                TaxAbility();
                Complete();
        }
    }
    public override List<CharacterSheet> HitList(GameObject target)
    {
        List<CharacterSheet> hits = new List<CharacterSheet>();
        foreach (CharacterSheet sheet in Initiative.nextInitiativeOrder)
        {
            if (target == sheet.shell.GetComponent<TileOccupation>().occupiedTile)
            {
                hits.Add(sheet);
            }
        }
        return hits;
    }
}
