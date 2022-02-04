using UnityEngine;

public class StageSelect : MonoBehaviour
{
    [SerializeField] Menu stages;
    [SerializeField] GameObject UIPrefab;
    public static GameObject currentUI;
    private void Awake()
    {
        currentUI = Instantiate(UIPrefab);
    }
    void Start()
    {
        currentUI.GetComponent<UIController>().OpenMenu(stages);
    }
}
