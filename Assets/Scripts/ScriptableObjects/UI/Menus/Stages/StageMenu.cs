using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "UI/Menus/Stages/Stage Select")]
public class StageMenu : Menu
{
    [SerializeField] List<SceneAsset> stages;
    void OnEnable()
    {
        contents = new List<object>();
        foreach (SceneAsset scene in stages)
        {
            contents.Add(scene);
        }
    }
    public override IEnumerator Open()
    {
        UI.OpenMenu(this, StageSelect.currentUI);
        yield return new WaitUntil(() => UI.done == true);
        SceneManager.LoadScene(UI.currentSelection.action.name);
    }
}
