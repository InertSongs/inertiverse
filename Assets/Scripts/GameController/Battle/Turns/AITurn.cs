using UnityEngine;

public class AITurn : MonoBehaviour, IDoTurn
{
    public void DoTurn()
    {
        Debug.Log("I went");
        Initiative.PassTurn();
    }
}
