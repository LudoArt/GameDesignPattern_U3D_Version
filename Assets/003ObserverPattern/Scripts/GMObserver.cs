using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMObserver : Observer
{
    public override void OnNotify(CustomEvent _event)
    {
        switch(_event)
        {
            case CustomEvent.OPENTITLE:
                GameManager.Instance.PauseGame();
                break;
            case CustomEvent.CLOSETITLE:
                GameManager.Instance.RunningGame();
                break;
            default:
                break;
        }
    }
}
