using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField]
    private Initiative initiative;
    [SerializeField]
    private LevelUnits levelUnits;
    [SerializeField]
    private List<Transform> spawnTiles;
    void Start()
    {
        levelUnits.Populate(spawnTiles);
        StartRound();
    }
    public void StartRound()
    {
        StartCoroutine(initiative.Turns());
    }

}
