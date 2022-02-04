using BehaviourTree;
using UnityEngine;


public class AIUseAbility : Node
{
    public override NodeState Evaluate()
    { 
        CharacterSheet activeSheet = Initiative.activePlayer;
        AIBestAbility.GetAbility(activeSheet).ActionSelection(AIBestAbility.GetTarget(activeSheet));
        state = NodeState.SUCCESS;
        return state;
    }
}
