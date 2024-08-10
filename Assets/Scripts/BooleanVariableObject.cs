using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class BooleanVariableObject : ScriptableObject
{
    public bool _booleanValue;

    public void SetTrue (BooleanVariableObject booleanValue)
    {
        booleanValue._booleanValue = true;
    }

    public void SetFalse (BooleanVariableObject booleanValue)
    {
        booleanValue._booleanValue = false;
    }
}