using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManualTurn : MonoBehaviour, IDoTurn
{
    private int dex;
    public EventBool passTurn;
    public EventGameObject startTurn;
    public bool myTurn = false;
    public bool canMove = false;
    

    public void DoTurn()
    {
        myTurn = true;
        canMove = true;
        startTurn.Raise(gameObject);
        Debug.Log("I'm " + gameObject.name + ", and I just went.");
    }
    public void PassTurn()
    {
        myTurn = false;
    }
    
}
