using System;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    public Action action;

    public void Update()
    {
        if (Input.anyKey == false)
        {
            return;
        }

        if (action != null)
        {
            action.Invoke();
        }
    }
}
