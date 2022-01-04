using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
using System;

public class HandleSelection
{
    public delegate void SelectionHandler(object selection);
    public static SelectionHandler thisSelection;
    Dictionary<Type, SelectionHandler> selectionPair;
   
    private void Awake()
    {
        selectionPair.Add(Type.GetType("Ability"),HandleAbility);
    }
    void CastSelection(object selection)
    {
        thisSelection = selectionPair[selection.GetType()];
        thisSelection(selection);
    }
    void HandleAbility(object selection) 
    {
        
    }


}
