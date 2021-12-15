using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wait : MonoBehaviour
{
    public EventBool passTurn;

    public void PassTurn()
    {
        passTurn.Raise(true);
    }
}
