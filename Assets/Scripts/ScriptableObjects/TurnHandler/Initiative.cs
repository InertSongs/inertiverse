using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class Initiative : ScriptableObject
{
    [SerializeField]
    private EventBool roundOver;
    public List<CurrentInitiativeOrder> currentInitiativeOrder = new List<CurrentInitiativeOrder>();
    public bool passTurn;
    public CurrentInitiativeOrder activePlayer;
    
    public void addInitiative(GameObject initiative, CharacterSheet sheet)
    {    
        currentInitiativeOrder.Add(new CurrentInitiativeOrder(initiative, sheet));
        currentInitiativeOrder.Sort();
    }
    public IEnumerator Turns()
    {
        List<CurrentInitiativeOrder> thisInitiativeOrder = currentInitiativeOrder;   
        for (int i = 0; i < thisInitiativeOrder.Count; i++)
        {
            passTurn = false;
            activePlayer = thisInitiativeOrder[i];
            thisInitiativeOrder[i].unit.GetComponent<IDoTurn>().DoTurn();
            yield return new WaitUntil(() => passTurn == true);
            if (thisInitiativeOrder.Count-1 == i)
            {
                roundOver.Raise(true);
            }
        }
       
    }
    public void PassTurn()
    {
        passTurn = true;
    }
}
