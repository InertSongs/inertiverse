using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ability : ScriptableObject
{
    public int actionRange;
    enum targetType {SingleUnit, SingleTileAoE};
    [SerializeField]
    private targetType myTargetType;
    [SerializeField]
    private Initiative initiative;

    private void OnEnable()
    {
        
    }
}
