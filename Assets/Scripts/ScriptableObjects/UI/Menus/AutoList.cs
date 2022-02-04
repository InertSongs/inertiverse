using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewListGenerator", menuName = "UI/List Generator")]
public class AutoList : ScriptableObject
{
    [SerializeField] Button buttonPrefab;
    [SerializeField] int buttonOffset;

    public List<ButtonPair> PopUp<T>(List<T> forButtons, GameObject currentUI)
    {
        List<ButtonPair> buttonsReturned = new List<ButtonPair>();
        List<Object> labels = forButtons.OfType<Object>().ToList();
        for (int i = 0; i < forButtons.Count; i++)
        {
            Button thisButton = Instantiate(buttonPrefab, new Vector2(100, (i + 1) * buttonOffset), buttonPrefab.transform.rotation);
            thisButton.transform.SetParent(currentUI.transform);
            buttonsReturned.Add(new ButtonPair(thisButton, labels[i]));
            thisButton.GetComponentInChildren<TextMeshProUGUI>().text = labels[i].name;
        }
        return buttonsReturned;
    }
}
