using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurn : MonoBehaviour, IDoTurn
{
    
    public int dex;
    public EventBool passTurn;

    public void DoTurn()
    {
        dex = gameObject.GetComponent<UnitLoader>().sheet.race.dexMod + gameObject.GetComponent<UnitLoader>().sheet.race.stats.dex;
        Debug.Log("I'm " + gameObject.name + ", my dex is " + dex + ", and I just went.");
        passTurn.Raise(true);
       
    }
}
