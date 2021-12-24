using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BattleState : MonoBehaviour

{
    public EventBool setSpawns;
    private List<CurrentInitiativeOrder> initiative;
    private List<GameObject> hasGone = new List<GameObject>();
    public bool passTurn;

    void Start()
    {
        SetupBattle();
    }
    void SetupBattle()
    {
        setSpawns.Raise(true);
        RoundStart();
    }
    void RoundStart()
    {
        for (int i = 0; i < initiative.Count; i++)
        {
            hasGone.Add(initiative[i].unit);
        }
        StartCoroutine(Turns());
        
    }
    IEnumerator Turns()
    {
        int thisTurnCount = hasGone.Count;
        for(int i = 0;i<thisTurnCount;i++)
        {
            passTurn = false;
            hasGone[0].GetComponent<IDoTurn>().DoTurn();
            hasGone.RemoveAt(0);
            yield return new WaitUntil(() => passTurn == true);
        }
        yield return new WaitUntil(() => hasGone.Count == 0);
        RoundStart();
        
    }
    
    void AcceptInitative(List<CurrentInitiativeOrder> newInitiative)
    {
        initiative = newInitiative;  
    }
    
    public void PassTurn()
    {
        passTurn = true;
    }

}
