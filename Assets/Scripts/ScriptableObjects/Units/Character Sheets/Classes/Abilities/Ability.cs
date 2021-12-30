using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ability : ScriptableObject
{
    public Initiative initiative;
    public int actionRange;
   public virtual void Perform(bool manual)
    {
        
    }
}
