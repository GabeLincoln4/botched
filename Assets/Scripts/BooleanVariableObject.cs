using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class BooleanVariableObject : ScriptableObject
{
    public bool _booleanValue;

    public void SetTrue ()
    {
        _booleanValue = true;
    }

    public void SetFalse ()
    {
        _booleanValue = false;
    }
}