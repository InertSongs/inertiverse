using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TileSelectorSpawner : MonoBehaviour
{
    private GameObject currentTurnPlayer;
    public GameObject tileSelector;
    private Vector3[] checkTiles = new[] { new Vector3(0, 0, 2), new Vector3(2, 0, 0), new Vector3(0, 0, -2), new Vector3(-2, 0, 0) };

    public void SetActivePlayer(GameObject turnStarter)
    {
        currentTurnPlayer = turnStarter;
    }
    public void SpawnTileChooser(InputAction.CallbackContext context)
    {
        if (context.performed)

        {
            for (int i = 0; i < checkTiles.Length; i++)
                if (!Physics.Raycast(currentTurnPlayer.transform.position, checkTiles[i], currentTurnPlayer.GetComponent<UnitLoader>().sheetDex))
                {
                    Instantiate(tileSelector, currentTurnPlayer.transform.position + checkTiles[i], currentTurnPlayer.transform.rotation);
                    break;
                }
        }
        else
        {
            KillSelector(context);
        }
        
    }
    public void KillSelector(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            GameObject[] tileSelectors = GameObject.FindGameObjectsWithTag("TileSelector");
            for (int i = 0; i < tileSelectors.Length; i++)
                Destroy(tileSelectors[i]);
        }
    }
}
