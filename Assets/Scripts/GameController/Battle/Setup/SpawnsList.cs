using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SpawnsList
{
    public CharacterSheet sheet;
    public Transform spawnLocation;
    public GameObject shell;

    public SpawnsList(CharacterSheet newSheet, Transform newLocation, GameObject newShell)
    {
        sheet = newSheet;
        spawnLocation = newLocation;
        shell = newShell;
    }

}

