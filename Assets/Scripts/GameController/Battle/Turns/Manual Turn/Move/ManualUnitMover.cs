using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManualUnitMover : MonoBehaviour
{
    public NavMeshAgent agent;
    public void MoveToSelector(Transform selection)
    {
        if(Vector3.Distance(selection.position,gameObject.transform.position)< gameObject.GetComponent<UnitLoader>().sheetDex)
        {
            agent.SetDestination(selection.position);
        }
    }
}
