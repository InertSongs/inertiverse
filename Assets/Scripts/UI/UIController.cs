using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIController : MonoBehaviour
{
    public AutoList listGenerator;
    Coroutine activeMenu;
    public void Increment(InputAction.CallbackContext context)
    {
        if (context.performed && UI.activeButtonList.Count > 0)
        {
            UI.currentSelection = UI.activeButtonList[ListNav.SetIndex(UI.activeButtonList.Count, UI.activeButtonList.IndexOf(UI.currentSelection) + Mathf.FloorToInt(context.ReadValue<float>()))];
            UI.currentSelection.button.Select();
        }
    }
    public void ConfirmSelection(InputAction.CallbackContext context)
    {
        if (context.started && UI.activeButtonList.Count > 0)
        {
            DestroyMenu();
            UI.done = true;
        }
    }
    public void Cancel(InputAction.CallbackContext context)
    {
        if (context.started && UI.activeButtonList.Count > 0)
        {
            backMenu();
        }
    }
    public void backMenu()
    {
        if (UI.menuHistory.Count > 1)
        {
            List<Menu> history = UI.menuHistory;
            Menu preceeding = history[UI.menuHistory.IndexOf(UI.activeMenu) - 1];
            StopCoroutine(activeMenu);
            history.Remove(UI.activeMenu);
            DestroyMenu();
            OpenMenu(preceeding);
        }
    }
    public void OpenMenu(Menu menu)
    {
        activeMenu = StartCoroutine(menu.Open());
    }
    void DestroyMenu()
    {
        for (int i = 0; i < UI.activeButtonList.Count; i++)
        {
            Destroy(UI.activeButtonList[i].button.gameObject);
        }
        UI.activeButtonList.Clear();
    }
}
