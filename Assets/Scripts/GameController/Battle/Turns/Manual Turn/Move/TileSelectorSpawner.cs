using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TileSelectorSpawner : MonoBehaviour
{
    private GameObject currentTurnPlayer;
    [SerializeField]
    private GameObject tileSelector;
    private int tileWidth = 2;
    private Vector3[] checkTiles; 

    private void Start()
    {
        checkTiles = new[] { new Vector3(0, 0, tileWidth), new Vector3(tileWidth, 0, 0), new Vector3(0, 0, -tileWidth), new Vector3(-tileWidth, 0, 0) };
    }
    public void SetActivePlayer(GameObject turnStarter)
    {
        currentTurnPlayer = turnStarter;
    }
    public void SpawnTileChooser(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            for (int i = 0; i < checkTiles.Length; i++)
                if (!Physics.Raycast(currentTurnPlayer.transform.position, checkTiles[i], tileWidth))
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
