using System.Collections.Generic;
using UnityEngine;

public class SetMoveRange : MonoBehaviour
{
    public List<WalkableTilesList> walkableTiles = new List<WalkableTilesList>();
    public void Set()
    {
        walkableTiles.Clear();
        GameObject[] levelTiles = GameObject.FindGameObjectsWithTag("Tile");
        int dex = gameObject.GetComponent<UnitLoader>().sheet.race.dexMod + gameObject.GetComponent<UnitLoader>().sheet.race.stats.dex;

        for (int i = 0; i < levelTiles.Length; i++)
        {
            float tileDistance = Vector3.Distance(levelTiles[i].transform.position, gameObject.transform.position);
            if (tileDistance < dex)
            {
                walkableTiles.Add(new WalkableTilesList(levelTiles[i]));
            }
        }
    }
}
