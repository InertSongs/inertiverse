using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActingPlayerHolder : MonoBehaviour
{
    public GameObject actingPlayer;

    public void SetActingPlayer(GameObject turnStarter)
    {
        actingPlayer = turnStarter;
    }

    public GameObject ActingPlayer()
    {
        return actingPlayer;
    }
}
