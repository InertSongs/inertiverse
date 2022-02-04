using System.Collections.Generic;
using UnityEngine;



public class HandleIndicators : MonoBehaviour
{
    Vector3 indicatorOffset = new Vector3(0, 1.5f, 0);
    List<GameObject> activeIndicators = new List<GameObject>();
    public void Spawn(List<GameObject> foundTiles, GameObject indicator)
    {
        for (int i = 0; i < foundTiles.Count; i++)
        {
            activeIndicators.Add(Instantiate(indicator, foundTiles[i].transform.position + foundTiles[i].transform.rotation * indicatorOffset, foundTiles[i].transform.rotation));
        }
    }
    public void Kill()
    {
        foreach (GameObject indicator in activeIndicators)
        {
            Destroy(indicator);
        }
    }

}