using UnityEngine;
using UnityEngine.UI;

public class ButtonPair
{
    public Button button;
    public Object action;
    public ButtonPair(Button newButton, Object newAction)
    {
        button = newButton;
        action = newAction;
    }
}
