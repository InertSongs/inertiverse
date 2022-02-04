using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewActionSet", menuName = "Turn Logic/Action Set")]
public class ActionSet : ScriptableObject
{
    public List<RootTurnAction> defaultActionSet;
    public RootTurnAction move;
    public RootTurnAction ability;

    private void OnEnable()
    {
        defaultActionSet.Clear();
        defaultActionSet.Add(move);
        defaultActionSet.Add(ability);
    }

}
