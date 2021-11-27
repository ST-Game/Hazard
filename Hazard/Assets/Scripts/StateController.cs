using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Collider2D))]
public class StateController : MonoBehaviour
{
    private Collider2D controlledObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controlledObject = collision;

        // Exit if object has no state manager
        IStateful sm = controlledObject.GetComponent<IStateful>();
        if(sm == null) return;

        sm.switchState();
        sm.displayState();
    }
}
