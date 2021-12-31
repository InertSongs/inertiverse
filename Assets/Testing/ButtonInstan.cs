using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInstan : MonoBehaviour
{
    public Button buttonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Button thisButton = Instantiate(buttonPrefab, new Vector2(0, 100), buttonPrefab.transform.rotation);
        thisButton.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
