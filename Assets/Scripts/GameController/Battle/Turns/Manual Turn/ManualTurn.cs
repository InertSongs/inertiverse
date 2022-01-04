using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManualTurn : MonoBehaviour, IDoTurn
{
    private GameObject UI;
    private void Start()
    {
        UI = FindObjectOfType<Canvas>().gameObject;
    }
    public void DoTurn()
    { 
       
    }
    public void ForcePassTurn(InputAction.CallbackContext context)
    {
        if (context.performed && gameObject == Initiative.activePlayer.unit)
        { Initiative.PassTurn(); }
    }
    public void UseAbility(InputAction.CallbackContext context)
    {
        if (context.performed && gameObject == Initiative.activePlayer.unit)
        {
            UI.GetComponent<UIController>().OpenMenu(Initiative.activePlayer.sheet.characterClass.classAbilities);
        }
         
    }
    public void PassTurn()
    {
        Initiative.PassTurn();
    }
    
}
