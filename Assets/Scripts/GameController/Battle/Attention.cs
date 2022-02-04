using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Attention : MonoBehaviour
{
    public static Dictionary<CharacterSheet, Dictionary<CharacterSheet, int>> attentionDatabase;

    public static void Affect(CharacterSheet effector, CharacterSheet affected, int effect)
    {
        Dictionary<CharacterSheet, int> attention = attentionDatabase[affected];
        attention[effector] += effect;
        if (attention[effector] >= affected.attentionThreshold)
        {
            CharacterSheet deadUnit = affected;
            Initiative.nextInitiativeOrder.Remove(deadUnit);
            affected.shell.GetComponent<TileOccupation>().ResetTile();
            Destroy(affected.shell);
            foreach (CharacterSheet sheet in Initiative.nextInitiativeOrder)
            {
                if (attentionDatabase[sheet].Keys.Contains(affected))
                {
                    attentionDatabase[sheet].Remove(affected);
                }
            }
        }
    }
    public void Setup()
    {
        attentionDatabase = new Dictionary<CharacterSheet, Dictionary<CharacterSheet, int>>();
        foreach (CharacterSheet sheet in BattleSystem.startingUnits.unitsInThisLevel)
        {
            Dictionary<CharacterSheet, int> myAttention = new Dictionary<CharacterSheet, int>();
            attentionDatabase.Add(sheet, myAttention);
            foreach (CharacterSheet otherSheet in BattleSystem.startingUnits.unitsInThisLevel)
            {
                if (otherSheet != sheet)
                {
                    attentionDatabase[sheet].Add(otherSheet, 0);
                }
            }
        }
    }
}
