using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterClass", menuName = "Character Sheets/Attributes/Character Class")]
public class CharacterClass : ScriptableObject
{
    [SerializeField] public List<Ability> classAbilities = new List<Ability>();
}
