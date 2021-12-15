using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable] public class TransformUnityEvent : UnityEvent<Transform> { }

public class ListenerTransform : ListenerTemplate<Transform>
{
    [SerializeField] private EventTransform eventTransform;
    [SerializeField] private TransformUnityEvent transformUnityEvent;

    // override and populate the two abstract properties
    // with the references from the serialized fields
    public override UnityEvent<Transform> unityEvent => transformUnityEvent;
    public override EventTemplate<Transform> gameEvent => eventTransform;
}
