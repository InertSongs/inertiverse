using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class SpawnIndicators : MonoBehaviour
{
    private Vector3 indicatorOffset = new Vector3(0, 1.5f, 0);
    private GameObject thisTurnPlayer;
    [SerializeField]
    private GameObject moveRangeIndicator;
    [SerializeField]
    private GameObject actionRangeIndicator;
    

    public void DoMove(InputAction.CallbackContext context)
    {
        
        ManageVisibleTiles(context, SetRange.Set(GameObject.FindGameObjectsWithTag("Tile"), thisTurnPlayer.GetComponent<UnitLoader>().sheet.sheetDex,thisTurnPlayer), moveRangeIndicator);
        
    }
    public void DoAction(InputAction.CallbackContext context)
    {
        ManageVisibleTiles(context, SetRange.Set(GameObject.FindGameObjectsWithTag("Tile"), thisTurnPlayer.GetComponent<UnitLoader>().sheet.characterClass.classAbilities[0].actionRange,thisTurnPlayer), actionRangeIndicator);
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
    public void UpdateActivePlayer(GameObject manualTurnStarter)
    {
        thisTurnPlayer = manualTurnStarter;
    }
}