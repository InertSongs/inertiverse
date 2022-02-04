using BehaviourTree;

public class AIIsMoving : Node
{
    public override NodeState Evaluate() => Initiative.activeShell.GetComponent<TileOccupation>().inMotion == false ? NodeState.SUCCESS : NodeState.FAILURE;
}
