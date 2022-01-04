using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Initiative
{
    public static List<CurrentInitiativeOrder> currentInitiativeOrder;
    public static bool passTurn;
    public static CurrentInitiativeOrder activePlayer;
    public static bool combatActive;
    public static List<GameObject> shellOrder;


    public static void AddInitiative(GameObject thisUnit, CharacterSheet sheet)
    {    
        currentInitiativeOrder.Add(new CurrentInitiativeOrder(thisUnit, sheet));
        currentInitiativeOrder.Sort();
    }
    public static IEnumerator Turns()
    {
        while (combatActive == true)
        {
            List<CurrentInitiativeOrder> thisInitiativeOrder = currentInitiativeOrder;
            shellOrder = thisInitiativeOrder.Select(thisInitiativeOrder => thisInitiativeOrder.unit).ToList();
            for (int i = 0; i < thisInitiativeOrder.Count; i++)
            {
                passTurn = false;
                activePlayer = thisInitiativeOrder[i];
                thisInitiativeOrder[i].unit.GetComponent<IDoTurn>().DoTurn();
                yield return new WaitUntil(() => passTurn == true);
            }
        }
    }
    public static void PassTurn()
    {
        passTurn = true;
    }
}
