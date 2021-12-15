using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable] public class InitiativeListUnityEvent : UnityEvent<List<CurrentInitiativeOrder>> { }

public class ListenerInitiativeList : ListenerTemplate<List<CurrentInitiativeOrder>>
{
    [SerializeField] private EventInitiativeList eventInitiativeList;
    [SerializeField] private InitiativeListUnityEvent initiativeListUnityEvent;

    // override and populate the two abstract properties
    // with the references from the serialized fields
    public override UnityEvent<List<CurrentInitiativeOrder>> unityEvent => initiativeListUnityEvent;
    public override EventTemplate<List<CurrentInitiativeOrder>> gameEvent => eventInitiativeList;
}
