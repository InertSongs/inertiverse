using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEventListener<in T>
{
    void OnEventRaised(T value);
}
