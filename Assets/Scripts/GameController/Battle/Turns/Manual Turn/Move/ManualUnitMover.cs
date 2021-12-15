using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManualUnitMover : MonoBehaviour
{
    public NavMeshAgent agent;
    public void MoveToSelector(Transform selection)
    {
        int dex = gameObject.GetComponent<UnitLoader>().sheet.race.stats.dex;
        Debug.Log(Vector3.Distance(selection.position,gameObject.transform.position)+" "+dex);
        if(Vector3.Distance(selection.position,gameObject.transform.position)<dex)
        {
            Debug.Log("I'm trying");
            agent.SetDestination(selection.position);
        }
    }
}
