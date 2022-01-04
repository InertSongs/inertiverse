using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ability : ScriptableObject
{
   public int actionRange;
   public GameObject UI;
    private void OnEnable()
    {
        UI = FindObjectOfType<Canvas>().gameObject;
    }
    public virtual void PerformManual()
   {
        
   }
}
