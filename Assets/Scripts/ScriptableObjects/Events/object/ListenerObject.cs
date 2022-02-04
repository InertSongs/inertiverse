using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable] public class ObjectUnityEvent : UnityEvent<object> { }

public class ListenerObject : ListenerTemplate<object>
{
    [SerializeField] EventObject eventObject;
    [SerializeField] ObjectUnityEvent objectUnityEvent;

    public override UnityEvent<object> unityEvent => objectUnityEvent;
    public override EventTemplate<object> gameEvent => eventObject;
}
