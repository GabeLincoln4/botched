using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmationOutput : MonoBehaviour
{
    private Color GetColor (Transform gameObject)
    {   
        return gameObject.GetComponent<MeshRenderer>().material.color; 
    }

    public void IncrementAlphaValue (Transform targetGameObject)
    {
        Color materialColor = GetColor(targetGameObject);
        materialColor.a += .25f * Time.deltaTime;
        targetGameObject.GetComponent<MeshRenderer>().material.color = materialColor;
    }


}
