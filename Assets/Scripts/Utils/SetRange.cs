using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SetRange
{
    public static List<T> Set<T>(List<T> checklist,int checkDistance, GameObject setter)
    {
        List<GameObject> checkObjects = checklist.OfType<GameObject>().ToList();
        List<T> foundObjects = new List<T>();
        for(int i = 0; i < checklist.Count;i++)
            {
                if (Vector3.Distance(checkObjects[i].transform.position, setter.transform.position) < checkDistance)
                {
                foundObjects.Add(checklist[i]);
                }
            }
        return foundObjects;
    }
}
