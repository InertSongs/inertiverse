using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UI/Menus/Combat/Turn Root")]
public class RootTurnMenu : CombatMenu
{
    public EventObject wait;
    public override IEnumerator Open()
    {
        contents = new List<object>();
        foreach (RootTurnAction action in Initiative.activePlayer.maxAP.Keys)
        {
            if (Initiative.activePlayer.currentAP[action] > 0)
            {
                contents.Add(action);
            }
        }
        contents.Add(wait);
        UI.menuHistory = new List<Menu>();
        UI.OpenMenu(this, BattleSystem.currentUI);
        yield return new WaitUntil(() => UI.done == true);
        if (UI.currentSelection.action != wait)
        {
            RootTurnAction toPerform = UI.currentSelection.action as RootTurnAction;
            toPerform.SelectedInCombat();
        }
        else
        {
            GameObject unit = Initiative.activeShell;
            Initiative.passTurn = true;
        }

    }
}
