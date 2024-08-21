using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmationOutput : MonoBehaviour
{
    [SerializeField]
    [Range(.1f, 1f)]
    private float _durationOfFadeIn;

    private Color GetColor (Transform gameObject)
    {   
        return gameObject.GetComponent<MeshRenderer>().material.color; 
    }

    public void IncrementAlphaValue (Transform targetGameObject)
    {
        Color materialColor = GetColor(targetGameObject);
        if (materialColor.a <= 1f)
        {
            materialColor.a += _durationOfFadeIn * Time.deltaTime;
            targetGameObject.GetComponent<MeshRenderer>().material.color = materialColor;
        }
    }


}
