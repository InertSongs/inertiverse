using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Linq;

public class UIController : MonoBehaviour
{
    private List<ButtonPair> activeButtonList;
    private ButtonPair currentSelection;
    
    public void OpenMenu<T>(List<T> menuRequest)
    {
        activeButtonList = new List<ButtonPair>();
        activeButtonList = gameObject.GetComponent<AutoList>().PopUp(menuRequest);
        currentSelection = activeButtonList[0];
        currentSelection.button.Select();
    }
    public void IncrementSelection(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            currentSelection = activeButtonList[ListNav.SetIndex(activeButtonList.Count, activeButtonList.IndexOf(currentSelection) + Mathf.FloorToInt(context.ReadValue<float>()))];
            currentSelection.button.Select();
        }
    }
    public void ConfirmSelection(InputAction.CallbackContext context)
    {
        for (int i = 0; i < activeButtonList.Count; i++)
        {
            Destroy(activeButtonList[i].button.gameObject);
        }
    }
}
