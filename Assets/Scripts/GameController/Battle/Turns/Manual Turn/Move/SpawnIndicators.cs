using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class SpawnIndicators : MonoBehaviour
{
    private Vector3 indicatorOffset = new Vector3(0, 1.5f, 0);
    [SerializeField]
    private Initiative initiative;
    [SerializeField]
    private GameObject moveRangeIndicator;
    [SerializeField]
    private GameObject actionRangeIndicator;
    

    public void DoMove(InputAction.CallbackContext context)
    {
        List<GameObject> checkTiles = new List<GameObject>(GameObject.FindGameObjectsWithTag("Tile"));
        ManageVisibleTiles(context, SetRange.Set(checkTiles, initiative.activePlayer.sheet.sheetDex,initiative.activePlayer.unit), moveRangeIndicator);   
    }
    public void DoAction(InputAction.CallbackContext context)
    {
        List<GameObject> checkTiles = new List<GameObject>(GameObject.FindGameObjectsWithTag("Tile"));
        ManageVisibleTiles(context, SetRange.Set(checkTiles, initiative.activePlayer.sheet.characterClass.classAbilities[0].actionRange,initiative.activePlayer.unit), actionRangeIndicator);
    }
    private void ManageVisibleTiles(InputAction.CallbackContext context, List<GameObject> foundTiles, GameObject indicator)
    {
        if (context.performed)
        {
            for (int i = 0; i < foundTiles.Count; i++)
            {
                GameObject thisTile = foundTiles[i];
                Vector3 rotatedOffset = thisTile.transform.rotation * indicatorOffset;
                Instantiate(indicator, thisTile.transform.position + rotatedOffset, thisTile.transform.rotation);
            }
        }
        else
        {
            GameObject[] indicators = GameObject.FindGameObjectsWithTag("Indicator");
            for (int i = 0; i < indicators.Length; i++)
                Destroy(indicators[i]);
        }
    }
}