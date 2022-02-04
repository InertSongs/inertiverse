using BehaviourTree;
using System.Collections.Generic;


public class AITurnTree : BehaviourTree.Tree
{
    protected override Node SetupTree()
    {
        CharacterSheet active = Initiative.activePlayer;
        Dictionary<RootTurnAction, int> currentAP = active.currentAP;
        RootTurnAction ability = active.actionSet.ability;
        RootTurnAction move = active.actionSet.move;

        Node root =
            new Sequence(new List<Node>
            {
                new AIIsMoving(),

                new Selector(new List<Node>
                {
                    new Sequence(new List<Node>
                    {         
                        new APCheck(currentAP,ability),
                        new Sequence(new List<Node>
                        {
                            new CheckEnemyInRange(),
                            new AIUseAbility(),
                        }),
                    }),
                    new Sequence(new List<Node>
                    {
                        new APCheck(currentAP,ability),
                        new APCheck(currentAP,move),
                        new CheckEnemyInRange(),
                        new AIApproach(),
                    }),
                    new Sequence(new List<Node>
                    {
                        new APCheck(currentAP,move),
                        new AIMove(),
                    }),
                    new AIPassTurn(),
                }),
            });
        return root;
    }
}
