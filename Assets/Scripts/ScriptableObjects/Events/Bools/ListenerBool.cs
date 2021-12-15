using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable] public class BoolUnityEvent : UnityEvent<bool> { }

public class ListenerBool : ListenerTemplate<bool>
{
    [SerializeField] private EventBool eventBool;
    [SerializeField] private BoolUnityEvent boolUnityEvent;

    // override and populate the two abstract properties
    // with the references from the serialized fields
    public override UnityEvent<bool> unityEvent => boolUnityEvent;
    public override EventTemplate<bool> gameEvent => eventBool;
}
