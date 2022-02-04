using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterSheet", menuName = "Character Sheets/New Character Sheet")]
public class CharacterSheet : ScriptableObject
{
    [SerializeField] UnitRace race;
    [SerializeField] UnitStats unitStats;
    public int attentionThreshold, sheetDex;
    public ActionSet actionSet;
    public bool AITurn = false;
    public CharacterClass characterClass;
    [SerializeField] GameObject model;
    public GameObject shell;
    public Menu combatRoot;
    public Dictionary<RootTurnAction, int> maxAP, currentAP;
    public Vector3 spawnOffset;
    public Faction faction;


    private void OnEnable()
    {
        spawnOffset = new Vector3(0, 2, 0);
        maxAP = new Dictionary<RootTurnAction, int>();
        currentAP = new Dictionary<RootTurnAction, int>();
        foreach (RootTurnAction action in actionSet.defaultActionSet)
        {
            maxAP.Add(action, action.defaultAP);
            currentAP.Add(action, action.defaultAP);
        }
        sheetDex = unitStats.dex + race.dexMod;
    }
    public void Upkeep()
    {
        foreach (RootTurnAction action in maxAP.Keys)
        {
            currentAP[action] += maxAP[action] - currentAP[action];
        }
    }
    public void Spawn(Transform location)
    {
        shell = Instantiate(model, location.position + location.rotation * spawnOffset, location.rotation);
        shell.GetComponent<TileOccupation>().SetTile(null);
        Initiative.nextInitiativeOrder.Add(this);
        Initiative.nextInitiativeOrder = Initiative.nextInitiativeOrder.OrderByDescending(x => x.sheetDex).ToList();
    }
}