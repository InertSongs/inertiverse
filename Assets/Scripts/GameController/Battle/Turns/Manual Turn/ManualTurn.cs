using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManualTurn : MonoBehaviour, IDoTurn
{
    [SerializeField]
    private Initiative initiative;
    public void DoTurn()
    { 
       
    }
    public void ForcePassTurn(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            PassTurn();
        }
    }
    public void PassTurn()
    {
        initiative.PassTurn();
    }
    
}
