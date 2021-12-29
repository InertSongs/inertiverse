using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionHandler : MonoBehaviour
{
    [SerializeField]
    private Initiative initiative;
    [SerializeField]
    private Ability ability;
    private CurrentInitiativeOrder target;
    private List<CurrentInitiativeOrder> validTargets;
    public void ChooseTarget(InputAction.CallbackContext context)
    {
        if (context.performed && gameObject == initiative.activePlayer.unit)
        {
            validTargets = ActionTargets.SetTargets(initiative, ability);
            if (validTargets.Count > 0)
            {
                target = validTargets[0];
            }
            else
            {
                Debug.Log("No Valid Targets");
            }
        }
        if (context.canceled && target != null)

        {
            PerformAction(target);
        }
    }
    public void IncrementTargetList(InputAction.CallbackContext context)
    {
        if (context.started && target != null && gameObject == initiative.activePlayer.unit)
        {
            target = validTargets[ListNav.SetIndex(validTargets.Count,validTargets.IndexOf(target)+Mathf.FloorToInt(context.ReadValue<float>()))];
        }
    }
    public void PerformAction(CurrentInitiativeOrder target)
    {
        Debug.Log("Action Performed");
    }
}
