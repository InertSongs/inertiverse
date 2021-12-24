using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurn : MonoBehaviour, IDoTurn
{
    public EventBool passTurn;

    public void DoTurn()
    {
        passTurn.Raise(true); 
    }
}
