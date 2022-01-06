using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class AutoList : MonoBehaviour
{
    [SerializeField]
    private Button buttonPrefab;
    [SerializeField]
    private int buttonOffset;

    public List<ButtonPair> PopUp<T>(List<T> forButtons)
    {
       List<ButtonPair> buttonsReturned = new List<ButtonPair>();
       List<Object> labels = forButtons.OfType<Object>().ToList();
       for (int i = 0; i < forButtons.Count; i++)
       {
            Button thisButton = Instantiate(buttonPrefab, new Vector2(100, (i + 1) * buttonOffset), buttonPrefab.transform.rotation);
            thisButton.transform.SetParent(gameObject.transform);
            buttonsReturned.Add(new ButtonPair(thisButton,labels[i]));
            thisButton.GetComponentInChildren<TextMeshProUGUI>().text = labels[i].name;
       }
       return buttonsReturned;
    }
}
