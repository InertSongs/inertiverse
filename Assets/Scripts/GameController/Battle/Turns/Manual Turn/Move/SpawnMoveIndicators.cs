using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class SpawnMoveIndicators : MonoBehaviour
{
    private Vector3 indicatorOffset = new Vector3(0, 1.5f, 0);
    private GameObject thisTurnPlayer;
    public GameObject indicator;

    public void DoMove(InputAction.CallbackContext context)
    {
        thisTurnPlayer.GetComponent<SetMoveRange>().Set();
        List<WalkableTilesList> currentWalkableTiles = thisTurnPlayer.GetComponent<SetMoveRange>().walkableTiles;
        if (thisTurnPlayer.GetComponent<ManualTurn>().myTurn == true && context.performed)
        {
            for (int i = 0; i < currentWalkableTiles.Count; i++)
            {
                GameObject thisTile = currentWalkableTiles[i].walkableTile;
                Vector3 rotatedOffset = thisTile.transform.rotation * indicatorOffset;
                Instantiate(indicator, thisTile.transform.position + rotatedOffset, thisTile.transform.rotation);
            }
        }
        else
        {
            GameObject[] indicators = GameObject.FindGameObjectsWithTag("Indicator");
            for(int i = 0; i<indicators.Length;i++)
            Destroy(indicators[i]);
        }
    }
    public void UpdateActivePlayer(GameObject manualTurnStarter)
    {
        thisTurnPlayer = manualTurnStarter;
    }
}