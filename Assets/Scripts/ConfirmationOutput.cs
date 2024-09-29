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

    public void IncrementAlphaValue ()
    {
        GetColor();
        AssertThatMaterialColorAlphaIsGreaterThanMaximumAlphaValue();
        Increment();
    }

    private void GetColor ()
    { _materialColor = _targetGameObject.GetComponent<MeshRenderer>().material.color; }

    private void OutputMessage()
    { Debug.Log("material color is less than maximum alpha value"); }

    private void Increment()
    {
        _materialColor.a += _durationOfFadeIn * Time.deltaTime;
        _targetGameObject.GetComponent<MeshRenderer>().material.color = _materialColor;
    }

    private void AssertThatMaterialColorAlphaIsGreaterThanMaximumAlphaValue()
    {
        if (_materialColor.a > _maximumAlphaValue)
        { return; }
    }

}
