using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAOEAbility", menuName = "Character Sheets/Abilities/AOE")]
public class AOE : Ability
{
    public int affectRange;
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
            foreach (CharacterSheet sheet in HitList(selection))
            {
                Attention.Affect(Initiative.activePlayer, sheet, attentionEffect);
            }
            TaxAbility();
            Complete();
        }
    }
    public  override List<CharacterSheet> HitList(GameObject target)
    {
        List<CharacterSheet> affected = new List<CharacterSheet>();
        Transform ofSelector = target.transform;
        Collider[] sphereHits = Physics.OverlapSphere(ofSelector.position, affectRange);
        foreach (Collider hit in sphereHits)
        {
            foreach (CharacterSheet sheet in Initiative.nextInitiativeOrder)
            {
                if (hit.gameObject == sheet.shell && Initiative.activePlayer != sheet)
                {
                    affected.Add(sheet);
                }
            }
        }
        return affected;
    }
}
