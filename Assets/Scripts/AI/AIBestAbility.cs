using System.Collections.Generic;
using UnityEngine;

public class AIBestAbility
{
    public static Ability bestAbility;
    public static GameObject bestTarget;
    public static void Set(CharacterSheet sheet)
    {
        bestAbility = null;
        bestTarget = null;
        float maxEffect = 0;
        GameObject me = sheet.shell;
        foreach (Ability ability in sheet.characterClass.classAbilities)
        {
            float range = sheet.sheetDex + ability.actionRange;
            List<GameObject> tileRange = new List<GameObject>();
            foreach (GameObject tile in GameObject.FindGameObjectsWithTag("Tile"))
            {
                if (Vector3.Distance(sheet.shell.GetComponent<TileOccupation>().occupiedTile.transform.position, tile.transform.position) <= range)
                {
                    tileRange.Add(tile);
                }
            }
            foreach(GameObject tile in tileRange)
            {
                float effect = ability.HitList(tile).Count * ability.attentionEffect;
                if (effect >= maxEffect)
                {
                    maxEffect = effect;
                    bestAbility = ability;
                    bestTarget = tile;
                }
            }
        }
    }
    public static Ability GetAbility(CharacterSheet sheet)
    {
        Set(sheet);
        return bestAbility;
    }
    public static GameObject GetTarget(CharacterSheet sheet)
    {
        Set(sheet);
        return bestTarget;
    }
}
