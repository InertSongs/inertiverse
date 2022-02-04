using BehaviourTree;

public class AIPassTurn : Node
{
    public override NodeState Evaluate()
    {
        Initiative.passTurn = true;
        AIBestAbility.bestAbility = null;
        AIBestAbility.bestTarget = null;
        state = NodeState.SUCCESS;
        return state;

    }
}
