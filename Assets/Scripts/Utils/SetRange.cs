using System.Collections.Generic;
using UnityEngine;

public class SetRange
{
    
    public static List<GameObject> Set(GameObject[] checklist,int checkDistance, GameObject setter)
    {
        List<GameObject> foundObjects = new List<GameObject>();
        for (int i = 0; i < checklist.Length; i++)
        {
            if (Vector3.Distance(checklist[i].transform.position, setter.transform.position) < checkDistance)
            {
                foundObjects.Add(checklist[i]);
            }
        }
        return foundObjects;
    }
}
