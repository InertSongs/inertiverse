using System.Collections.Generic;
using UnityEngine;

public class SetRange : MonoBehaviour
{
    
    public List<GameObject> Set(GameObject[] checklist,int checkDistance)
    {
        List<GameObject> foundTiles = new List<GameObject>();
        for (int i = 0; i < checklist.Length; i++)
        {
            if (Vector3.Distance(checklist[i].transform.position, gameObject.transform.position) < checkDistance)
            {
                foundTiles.Add(checklist[i]);
            }
        }
        return foundTiles;
    }
}
