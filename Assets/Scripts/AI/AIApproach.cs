using BehaviourTree;
using UnityEngine;

public class AIApproach : Node
{
    public override NodeState Evaluate()
    {
        Debug.Log("Approaching");
        CharacterSheet activeSheet = Initiative.activePlayer;
        Transform playerTransfrom = Initiative.activeShell.transform;
        GameObject movementTarget = new GameObject();
        for (int i = 0; i < Walkables.walkables.Count; i++)
        {
            Transform tileTransform = Walkables.walkables[i].transform;
            if (Vector3.Distance(playerTransfrom.position, tileTransform.position) < Initiative.activePlayer.sheetDex && Vector3.Distance(tileTransform.position, AIBestAbility.GetTarget(activeSheet).transform.position) < AIBestAbility.GetAbility(activeSheet).actionRange)
            {
                movementTarget = Walkables.walkables[i];
                parent.parent.SetData("destination", movementTarget);
                UnitMover.Use(Walkables.walkables[i], Initiative.activeShell);
                break;
            }
        }
        state = NodeState.SUCCESS;
        return state;
    }
}
