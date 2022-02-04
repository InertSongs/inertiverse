using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlTileSelector : MonoBehaviour
{
    RootTurnAction spawner;
    Vector3 offset = new Vector3(0, 2, 0);
    float inputScale = 1.5f;
    
    public void SetSpawner (RootTurnAction _spawner)
    {
        spawner = _spawner;
    }
    public void MoveIndicator(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Transform ofSelector = gameObject.transform;
            Collider[] sphereHits = Physics.OverlapSphere(ofSelector.position, 3);
            Vector3 inputToV3 = new Vector3(context.ReadValue<Vector2>().x * inputScale, 0, context.ReadValue<Vector2>().y * inputScale);
            List<float> tileDistances = new List<float>();
            foreach (Collider collider in sphereHits)
            {
                tileDistances.Add(Vector3.Distance(collider.gameObject.transform.position - gameObject.GetComponent<TileOccupation>().occupiedTile.transform.position, inputToV3));
            }
            GameObject target = sphereHits[tileDistances.IndexOf(tileDistances.Min())].gameObject;
            if (spawner.selectRange.Contains(target))
            {
                ofSelector.position = target.transform.position + target.transform.rotation * offset;
                ofSelector.rotation = target.transform.rotation;
            }
        }
    }
    public void TileSelected(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            spawner.ActionSelection(gameObject.GetComponent<TileOccupation>().occupiedTile);
        }
    }
    public void Cancel(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            spawner.CancelCombatSelection();
        }
    }
}
