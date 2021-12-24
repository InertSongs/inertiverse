using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterSheet : ScriptableObject
{
    [SerializeField]
    private bool friendlyUnit;
    public UnitRace race;
    public UnitStats unitStats;
    public GameObject visuals;
    public CharacterClass characterClass;

}
