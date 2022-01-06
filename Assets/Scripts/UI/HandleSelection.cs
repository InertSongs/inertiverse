using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
using System;

public class HandleSelection
{
    public delegate void SelectionHandler(object selection);
    public static SelectionHandler thisSelection;
    public static Dictionary<Type, SelectionHandler> selectionPair;
   
    public static void InitializeSelectionHandler()
    {
        selectionPair = new Dictionary<Type, SelectionHandler>();
        selectionPair.Add(Type.GetType("SingleUnitTarget"),HandleAbility);
        selectionPair.Add(Type.GetType("CharacterSheet"), HandleSheet);
    }
    public static void DelegateSelection(object selection)
    {
        thisSelection = selectionPair[selection.GetType()];
        thisSelection(selection);
    }
    public static void HandleAbility(object selection) 
    {
        Ability thisAbility = selection as Ability;
        thisAbility.PerformManual();
    }
    public static void HandleSheet(object selection)
    {

    }


}
