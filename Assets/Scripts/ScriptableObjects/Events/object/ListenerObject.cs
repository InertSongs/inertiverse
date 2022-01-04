using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable] public class ObjectUnityEvent : UnityEvent<object> { }

public class ListenerObject : ListenerTemplate<object>
{
    [SerializeField] private EventObject eventObject;
    [SerializeField] private ObjectUnityEvent objectUnityEvent;

    public override UnityEvent<object> unityEvent => objectUnityEvent;
    public override EventTemplate<object> gameEvent => eventObject;
}
