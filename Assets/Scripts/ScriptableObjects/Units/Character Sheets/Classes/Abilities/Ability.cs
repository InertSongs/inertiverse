using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(fileName = "NewRootAbilityAction", menuName = "Character Sheets/Abilities/Root")]
public class Ability : RootTurnAction
{
    public int actionRange, attentionEffect;
    [SerializeField] GameObject indicator;
    [SerializeField] Menu sub;

    public override void SelectedInCombat() => BattleSystem.currentUI.GetComponent<UIController>().OpenMenu(sub);  
    public void TaxAbility() => Initiative.activePlayer.currentAP[Initiative.activePlayer.actionSet.ability] -= 1;

    public virtual List<CharacterSheet> HitList(GameObject target)
    {
        return null;
    }
    public void ShowRange()
    {
        selectRange = SetRange.Set(GameObject.FindGameObjectsWithTag("Tile").ToList(), actionRange, Initiative.activePlayer.shell);
        BattleSystem.currentIndicatorHandler.Spawn(selectRange, indicator);
    }
}
