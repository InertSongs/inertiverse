using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] LevelUnits levelUnits;
    [SerializeField] List<Transform> spawnTiles;
    [SerializeField] GameObject UIPrefab;
    [SerializeField] NavMeshSurface boardPrefab;
    [SerializeField] SceneAsset stageSelect;
    public static LevelUnits startingUnits;
    public static GameObject currentUI;
    public static NavMeshSurface board;
    public static HandleIndicators currentIndicatorHandler;
    void Awake()
    {
        startingUnits = levelUnits;
        currentIndicatorHandler = gameObject.GetComponent<HandleIndicators>();
        currentUI = Instantiate(UIPrefab);
        Walkables.walkables = GameObject.FindGameObjectsWithTag("Tile").ToList();
        board = Instantiate(boardPrefab);
        board.BuildNavMesh();
        StartCombat();
    }
    public void StartCombat()
    {
        levelUnits.Populate(spawnTiles);
        gameObject.GetComponent<Attention>().Setup();
        StartCoroutine(StartRound());
    }
    public IEnumerator StartRound()
    {
        Initiative.combatActive = true;
        StartCoroutine(Initiative.Turns());
        yield return new WaitUntil(() => Initiative.nextInitiativeOrder.Count == 1);
        SceneManager.LoadScene(stageSelect.name);
    }
}
