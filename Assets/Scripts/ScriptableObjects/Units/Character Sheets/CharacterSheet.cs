using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterSheet : ScriptableObject
{
    [SerializeField]
    private bool friendlyUnit;
    [SerializeField]
    private UnitRace race;
    [SerializeField]
    private UnitStats unitStats;
    public CharacterClass characterClass;
    public int sheetDex;
    public int sheetAtt;
    public GameObject shell;

    private void OnEnable()
    {
        sheetDex = unitStats.dex + race.dexMod;
        sheetAtt = unitStats.attention + race.attentionMod;
    }
}