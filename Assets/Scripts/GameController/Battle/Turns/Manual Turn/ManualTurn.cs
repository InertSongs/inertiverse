using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManualTurn : MonoBehaviour, IDoTurn
{
    public EventGameObject startTurn;
    public bool myTurn = false;
    
    

    public void DoTurn()
    {
        myTurn = true;
       
        startTurn.Raise(gameObject);
       
    }
    public void PassTurn()
    {
        myTurn = false;
    }
    
}
