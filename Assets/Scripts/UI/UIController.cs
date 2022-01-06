using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIController : MonoBehaviour
{
    private List<ButtonPair> activeButtonList = new List<ButtonPair>();
    private ButtonPair currentSelection;

    private void Awake()
    {
        HandleSelection.InitializeSelectionHandler();
    }
    public void OpenMenu<T>(List<T> menuRequest)
    {
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
        if (context.performed)
        {
            for (int i = 0; i < activeButtonList.Count; i++)
            {
                Destroy(activeButtonList[i].button.gameObject);
            }
            HandleSelection.DelegateSelection(currentSelection.action);
        }
    }
}
