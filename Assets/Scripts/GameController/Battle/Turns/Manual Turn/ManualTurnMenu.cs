using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManualTurnMenu : MonoBehaviour
{
    private CanvasGroup canvas;
    public void appear(GameObject takingTurn)
    {
        canvas = gameObject.GetComponent<CanvasGroup>();
        canvas.alpha = 1;
        canvas.interactable = true;
        canvas.blocksRaycasts = true;
    }
    public void hide ()
    {
        canvas = gameObject.GetComponent<CanvasGroup>();
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
    }
    
}
