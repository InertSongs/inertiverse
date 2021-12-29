using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMover
{
    public static void MoveToSelector(Transform selection, CurrentInitiativeOrder activePlayer)
    {
        if(Vector3.Distance(selection.position,activePlayer.unit.transform.position)< activePlayer.sheet.sheetDex)
        {
            activePlayer.unit.GetComponent<NavMeshAgent>().SetDestination(selection.position);
        }
    }
}
