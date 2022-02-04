using System.Collections.Generic;
using UnityEngine;

public class UI
{
    public static List<ButtonPair> activeButtonList = new List<ButtonPair>();
    public static ButtonPair currentSelection;
    public static bool done;
    public static Menu activeMenu;
    public static List<Menu> menuHistory;

    public static void OpenMenu(Menu menuRequest, GameObject currentUI)
    {
        done = false;
        activeButtonList = currentUI.GetComponent<UIController>().listGenerator.PopUp(menuRequest.contents, currentUI);
        activeMenu = menuRequest;
        if (menuHistory != null)
        {
            if (!menuHistory.Contains(menuRequest))
            {
                menuHistory.Add(menuRequest);
            }
        }
        currentSelection = activeButtonList[0];
        currentSelection.button.Select();
    }
}
