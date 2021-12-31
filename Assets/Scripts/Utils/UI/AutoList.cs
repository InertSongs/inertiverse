using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AutoList : MonoBehaviour
{
    [SerializeField]
    private Button buttonPrefab;
    public void PopUp<T>(List<T> forButtons)
    {
        List<string> labels = new List<string>();
        for(int i = 0; i<forButtons.Count;i++)
        {
            Button thisButton = Instantiate(buttonPrefab,new Vector2(0,(i+1)*100),buttonPrefab.transform.rotation);
            labels.Add(forButtons.ToString());  
        }
        
    }
}
