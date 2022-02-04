using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Menu : ScriptableObject
{
    public List<object> contents;
    public virtual IEnumerator Open()
    {
        yield return null;
    }
}
