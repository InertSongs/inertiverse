using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.Events;
using System;

public class TileSelectorController : MonoBehaviour
{
    [SerializeField]
    private Initiative initiative;
    private float playerSpeed = 3f;
       
    public void Movement_performed(InputAction.CallbackContext context)
    {
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
        Vector2 inputVector = context.ReadValue<Vector2>();
        Vector3 yInputVector = new Vector3(inputVector.x, 0, inputVector.y) * playerSpeed ;
        Vector3 checkInputVector = gameObject.transform.position + yInputVector;
        agent.SetDestination(checkInputVector);
    }
    public void TileSelected(InputAction.CallbackContext context)
    {
        UnitMover.MoveToSelector(gameObject.transform,initiative.activePlayer);
    }
}
