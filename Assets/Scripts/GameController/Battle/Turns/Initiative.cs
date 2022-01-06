using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Initiative
{
    public static List<CurrentInitiativeOrder> nextInitiativeOrder;
    public static bool passTurn;
    public static CurrentInitiativeOrder activePlayer;
    public static bool combatActive;
    public static List<GameObject> shellOrder;
    public static List<CurrentInitiativeOrder> thisInitiativeOrder;


    public static void AddInitiative(GameObject thisUnit, CharacterSheet sheet)
    {    
        nextInitiativeOrder.Add(new CurrentInitiativeOrder(thisUnit, sheet));
        nextInitiativeOrder.Sort();
    }
    public static IEnumerator Turns()
    {
        while (combatActive == true)
        {
            thisInitiativeOrder = nextInitiativeOrder;
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
