using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UI/Menus/Combat/Combat Ability")]
public class CombatAbilityMenu : CombatMenu
{
    public override IEnumerator Open()
    {
        contents = new List<object>();
        contents.AddRange(Initiative.activePlayer.characterClass.classAbilities);
        UI.OpenMenu(this, BattleSystem.currentUI);
        yield return new WaitUntil(() => UI.done == true);
        Ability ability = UI.currentSelection.action as Ability;
        ability.SelectedInCombat();
    }
}
