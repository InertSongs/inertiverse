using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : Node
{
    public override NodeState Evaluate()
    {
        Debug.Log("AIMOVE");
        GameObject shell = Initiative.activeShell;
        List<GameObject> moveRange = SetRange.Set(Walkables.walkables, Initiative.activePlayer.sheetDex, shell.GetComponent<TileOccupation>().occupiedTile);
        GameObject closest = null;
        float minDistance = Mathf.Infinity;
        foreach (CharacterSheet otherSheet in Initiative.nextInitiativeOrder)
        {
            GameObject unit = otherSheet.shell;
            foreach (GameObject tile in moveRange)
            {
                float distance = Vector3.Distance(unit.transform.position, tile.transform.position);
                if (Initiative.activePlayer.faction != otherSheet.faction && unit != Initiative.activePlayer.shell && distance < minDistance && Walkables.walkables.Contains(tile))
                {
                    minDistance = distance;
                    closest = tile;
                }
            }
        }
        UnitMover.Use(closest, shell);
        state = NodeState.SUCCESS;
        return state;
    }
}
