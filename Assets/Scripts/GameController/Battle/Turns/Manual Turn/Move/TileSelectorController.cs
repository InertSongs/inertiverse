using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.Events;
using System;

public class TileSelectorController : MonoBehaviour
{
    public NavMeshAgent agent;
    private float playerSpeed = 3f;
    public EventTransform selectedTile;
       
    public void Movement_performed(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        Vector3 yInputVector = new Vector3(inputVector.x, 0, inputVector.y) * playerSpeed ;
        Vector3 checkInputVector = gameObject.transform.position + yInputVector;
        agent.SetDestination(checkInputVector);
    }
    public void TileSelected(InputAction.CallbackContext context)
    {
        selectedTile.Raise(gameObject.transform);
        Debug.Log("Move you fool");
    }


}
