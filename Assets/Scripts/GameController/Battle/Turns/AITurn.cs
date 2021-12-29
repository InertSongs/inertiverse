using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurn : MonoBehaviour, IDoTurn
{
    [SerializeField]
    private Initiative initiative;
    
    public void DoTurn()
    {
        Debug.Log("I went");
        initiative.PassTurn();
    }
}
