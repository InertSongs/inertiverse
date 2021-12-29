using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TileSelectorSpawner : MonoBehaviour
{
    [SerializeField]
    private Initiative initiative;
    [SerializeField]
    private GameObject tileSelector;
    private int tileWidth = 2;
    private Vector3[] checkTiles; 

    private void Start()
    {
        checkTiles = new[] { new Vector3(0, 0, tileWidth), new Vector3(tileWidth, 0, 0), new Vector3(0, 0, -tileWidth), new Vector3(-tileWidth, 0, 0) };
    }
    public void SpawnTileChooser(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            for (int i = 0; i < checkTiles.Length; i++)
                if (!Physics.Raycast(initiative.activePlayer.unit.transform.position, checkTiles[i], tileWidth))
                {
                    Instantiate(tileSelector, initiative.activePlayer.unit.transform.position + checkTiles[i], initiative.activePlayer.unit.transform.rotation);
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
