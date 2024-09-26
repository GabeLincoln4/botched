using UnityEngine;

public static class ScaleFunctionLibrary
{ 
    public static Vector3 AlterScaleOfGivenTransform(float scale)
    { return Vector3.one / scale; }
}