using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;

public class APCheck : Node
{
    RootTurnAction action;
    Dictionary<RootTurnAction, int> ap;
    public APCheck(Dictionary<RootTurnAction, int> _ap, RootTurnAction _action)
    {
        ap = _ap;
        action = _action;
    }
    public override NodeState Evaluate() => ap[action] > 0 ? NodeState.SUCCESS : NodeState.FAILURE;

}
