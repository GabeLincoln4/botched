using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmationOutput : MonoBehaviour
{
    [SerializeField]
    [Range(.1f, 1f)]
    private float _durationOfFadeIn;
    [SerializeField]
    private float _maximumAlphaValue;
    [SerializeField]
    private Transform _targetGameObject;
    private Color _materialColor;

    private Color GetColor ()
    {   
        return _targetGameObject.GetComponent<MeshRenderer>().material.color; 
    }

    public void IncrementAlphaValue ()
    {
        _materialColor = GetColor(_targetGameObject);
        if (_materialColor.a <= _maximumAlphaValue)
        {
            _materialColor.a += _durationOfFadeIn * Time.deltaTime;
            _targetGameObject.GetComponent<MeshRenderer>().material.color = _materialColor;
        }
    }
}
