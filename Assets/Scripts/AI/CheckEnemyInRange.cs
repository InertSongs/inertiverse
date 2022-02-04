using BehaviourTree;
using UnityEngine;

public class CheckEnemyInRange : Node
{
    public override NodeState Evaluate()
    {
        Ability bestAbility = AIBestAbility.GetAbility(Initiative.activePlayer);
        if (bestAbility != null)
        {
            state = NodeState.SUCCESS;
            return state;
        }
        else
        {
            state = NodeState.FAILURE;
            return state;
        }
    }
}
