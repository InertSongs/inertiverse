using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterClass : ScriptableObject
{
    [SerializeField]
    public List<Ability> classAbilities = new List<Ability>();
}
