using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMoveAction", menuName = "Turn Logic/Move")]
public class MoveAction : RootTurnAction
{
    [SerializeField] GameObject indicator;
    public override void SelectedInCombat()
    {

        selectRange = SetRange.Set(Walkables.walkables, Initiative.activePlayer.sheetDex, Initiative.activeShell.GetComponent<TileOccupation>().occupiedTile);
        BattleSystem.currentIndicatorHandler.Spawn(SetRange.Set(Walkables.walkables, Initiative.activePlayer.sheetDex, Initiative.activeShell.GetComponent<TileOccupation>().occupiedTile), indicator);
        SpawnTileSelector(this);
    }
    public override void ActionSelection(GameObject selection)
    {
        if (selectRange.Contains(selection))
        {
            KillTileSelector();
            UnitMover.Use(selection, Initiative.activeShell);
        }
    }
    
}
