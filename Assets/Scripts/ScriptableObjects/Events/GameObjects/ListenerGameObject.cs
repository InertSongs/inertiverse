using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable] public class GameObjectUnityEvent : UnityEvent<GameObject> { }

public class ListenerGameObject : ListenerTemplate<GameObject>
{
    [SerializeField] private EventGameObject eventGameObject;
    [SerializeField] private GameObjectUnityEvent gameObjectUnityEvent;

    // override and populate the two abstract properties
    // with the references from the serialized fields
    public override UnityEvent<GameObject> unityEvent => gameObjectUnityEvent;
    public override EventTemplate<GameObject> gameEvent => eventGameObject;
}
