using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Initiative
{
    public static List<CharacterSheet> thisInitiativeOrder, nextInitiativeOrder;
    public static bool passTurn, combatActive;
    public static CharacterSheet activePlayer;
    public static GameObject activeShell;

    public static IEnumerator Turns()
    {
        while (nextInitiativeOrder.Count > 1)
        {
            thisInitiativeOrder = new List<CharacterSheet>();
            thisInitiativeOrder.AddRange(nextInitiativeOrder);
            for (int i = 0; i < thisInitiativeOrder.Count; i++)
            {
                if (nextInitiativeOrder.Contains(thisInitiativeOrder[i]))
                {
                    passTurn = false;
                    activePlayer = thisInitiativeOrder[i];
                    activeShell = thisInitiativeOrder[i].shell;
                    activePlayer.Upkeep();
                    if (thisInitiativeOrder[i].AITurn == false)
                    {
                        GameObject currentUI = BattleSystem.currentUI;
                        currentUI.GetComponent<UIController>().OpenMenu(activePlayer.combatRoot);
                        yield return new WaitUntil(() => passTurn == true);
                    }
                    else
                    {
                        AITurnTree thisTree = activeShell.GetComponent<AITurnTree>();
                        thisTree.enabled = true;
                        yield return new WaitUntil(() => passTurn == true);
                        thisTree.enabled = false;
                    }
                }
            }
        }
    }
}
