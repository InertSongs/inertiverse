using UnityEngine;
using UnityEngine.AI;

public class UnitMover
{
    public static void Use(GameObject selection, GameObject unit)
    {
        NavMeshAgent agent = unit.GetComponent<NavMeshAgent>();
        TileOccupation control = unit.GetComponent<TileOccupation>();
        control.inMotion = true;
        control.ResetTile();
        agent.SetDestination(selection.transform.rotation * (selection.transform.position + new Vector3(0, 1, 0)));
        control.SetTile(selection);
    }
}
