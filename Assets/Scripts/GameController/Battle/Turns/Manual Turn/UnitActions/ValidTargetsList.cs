using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidTargetsList : MonoBehaviour
{
    public void GetValidTargets()
    {
        List<GameObject> validTargets = SetRange.Set(GameObject.FindGameObjectsWithTag("Unit"),gameObject.GetComponent<UnitLoader>().sheet.characterClass.classAbilities[0].actionRange,gameObject);
    }
}
