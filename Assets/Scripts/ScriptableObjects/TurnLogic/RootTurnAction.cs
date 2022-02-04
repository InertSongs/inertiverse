using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RootTurnAction : ScriptableObject
{
    [HideInInspector] public int defaultAP = 1;
    int tileWidth = 2;
    [SerializeField] GameObject selectorPrefab;
    [HideInInspector] public GameObject selector;
    [HideInInspector] public ControlTileSelector control;
    [HideInInspector] public List<GameObject> selectRange;
    public void Complete()
    {
        if (Initiative.activePlayer.AITurn == false)
        { 
            BattleSystem.currentUI.GetComponent<UIController>().OpenMenu(Initiative.activePlayer.combatRoot); 
        }
    }
    public virtual void ActionSelection(GameObject selection) { }
    public void CancelCombatSelection()
    {
        BattleSystem.currentUI.GetComponent<UIController>().OpenMenu(UI.menuHistory[UI.menuHistory.Count - 1]);
        KillTileSelector();
    }
    public abstract void SelectedInCombat();
    public void SpawnTileSelector(RootTurnAction spawner)
    {
        Vector3[] checkTiles = new[] { new Vector3(0, 0, tileWidth), new Vector3(tileWidth, 0, 0), new Vector3(0, 0, -tileWidth), new Vector3(-tileWidth, 0, 0) };
        GameObject unit = Initiative.activeShell;
        for (int i = 0; i < checkTiles.Length; i++)
            if (!Physics.Raycast(unit.transform.position, checkTiles[i], tileWidth))
            {
                selector = Instantiate(selectorPrefab, unit.transform.position + checkTiles[i], unit.transform.rotation);
                control = selector.GetComponent<ControlTileSelector>();
                control.SetSpawner(spawner);
                break;
            }
    }
    public void KillTileSelector()
    {
        BattleSystem.currentIndicatorHandler.Kill();
        Destroy(selector);
    }
}

